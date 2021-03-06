using System;

namespace Yam.Core.MSProject
{
    internal interface IDependencyNode
    {
    }

    internal static class NodeExtensions
    {
        public static string GetPath(this IDependencyNode node)
        {
            var projectNode = node as ProjectNode;
            var path = String.Empty;
            if (projectNode != null)
            {
                path = projectNode.FullPath;
            }
            var assemblyNode = node as AssemblyNode;
            if (assemblyNode != null)
            {
                path = assemblyNode.FullPath;
            }
            return path;
        }
    }
}