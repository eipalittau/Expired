using Exp.Util.Extension;
using System.Reflection;

namespace Exp.Exception {
    /// <summary>Die Ressource '{0}' konnte in der Assembly '{1}' nicht gefunden werden.</summary>
    public sealed class ResourceNotFoundException : ExceptionBase {
        public ResourceNotFoundException(string aResourceName, Assembly aAssembly)
            : base(aResourceName, aAssembly.TryGetName()) { }
}