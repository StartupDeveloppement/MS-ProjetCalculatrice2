using System;

namespace Projet.Niveau1.MoneyManagementCorrection.Affichage
{
    [AttributeUsage(AttributeTargets.Field)]
    public class TextesDescription : Attribute
    {
        private readonly string _settings;

        public TextesDescription(string texte)
        {
            _settings = texte;
        }

        public static string Get(Type tp, string name)
        {
            var mi = tp.GetMember(name);
            if (mi != null && mi.Length > 0)
            {
                var attr = GetCustomAttribute(mi[0],
                    typeof(TextesDescription)) as TextesDescription;
                if (attr != null)
                {
                    return attr._settings;
                }
            }
            return null;
        }

        public static string Get(object enm)
        {
            var mi = enm?.GetType().GetMember(enm.ToString());
            if (mi != null && mi.Length > 0)
            {
                var attr = GetCustomAttribute(mi[0],
                    typeof(TextesDescription)) as TextesDescription;
                if (attr != null)
                {
                    return attr._settings;
                }
            }
            return null;
        }
    }
}