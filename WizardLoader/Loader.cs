using McMaster.NETCore.Plugins;
using Shared;
using System;
using System.IO;
using System.Linq;

namespace WizardLoader
{
    public class Loader
    {
        private readonly string _wizardAssemblyPath;

        public Loader(string wizardAssemblyPath)
        {
            _wizardAssemblyPath = wizardAssemblyPath;
        }
        public IWizard LoadInstance(string wizardName)
        {
            foreach (var filePath in Directory.GetFiles(_wizardAssemblyPath, $"{wizardName}.dll", new EnumerationOptions { RecurseSubdirectories = true }))
            {
                var absolutePath = Path.GetFullPath(filePath);
                var loader = PluginLoader.CreateFromAssemblyFile(absolutePath, sharedTypes: new[] { typeof(IWizard) });
                
                var wizardType = loader.LoadDefaultAssembly().GetTypes().FirstOrDefault(t => typeof(IWizard).IsAssignableFrom(t) && !t.IsAbstract);

                if (wizardType is not null)
                {
                    return Activator.CreateInstance(wizardType) as IWizard;
                }
            }

            return null;
        }
    }
}
