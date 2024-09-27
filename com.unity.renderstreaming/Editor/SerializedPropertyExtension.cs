using UnityEditor;

namespace Unity.RenderStreaming.Editor
{
    public static class SerializedPropertyExtension
    {
        public static SerializedProperty FindPropertyInChildren(this SerializedProperty target, string propertyName)
        {
            SerializedProperty property = null;
            while (target.Next(true))
            {
                if (target.name == propertyName)
                {
                    property = target.Copy();
                    break;
                }
            }
            target.Reset();
            return property;
        }
    }
}
