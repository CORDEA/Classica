using System;
using Plugin.Classica.Abstractions;

namespace Plugin.Classica
{
    public class CrossClassica
    {
        static readonly Lazy<IClassica> Implementation = new Lazy<IClassica>(CreateClassica,
            System.Threading.LazyThreadSafetyMode.PublicationOnly);

        public static IClassica Current
        {
            get
            {
                var ret = Implementation.Value;
                if (ret == null)
                {
                    throw NotImplementedInReferenceAssembly();
                }
                return ret;
            }
        }

        static IClassica CreateClassica()
        {
#if PORTABLE
            return null;
#else
            return new ClassicaImplementation();
#endif
        }

        internal static Exception NotImplementedInReferenceAssembly()
        {
            return new NotImplementedException(
                "This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");
        }
    }
}