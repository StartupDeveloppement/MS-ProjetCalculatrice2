using System;

namespace Projet.Niveau1.MoneyManagementCorrection.Validation
{
    [AttributeUsage(AttributeTargets.Field)]
    public class ParametersDescription : Attribute
    {
        private readonly Parameters _settings;

        public ParametersDescription(int[] values, string texte)
        {
            _settings = new Parameters
            {
                Values = values,
                Texte = texte
            };
        }

        public static Parameters Get(Type tp, string name)
        {
            var mi = tp.GetMember(name);
            if (mi != null && mi.Length > 0)
            {
                var attr = GetCustomAttribute(mi[0],
                    typeof(ParametersDescription)) as ParametersDescription;
                if (attr != null)
                {
                    return attr._settings;
                }
            }
            return null;
        }

        public static Parameters Get(object enm)
        {
            var mi = enm?.GetType().GetMember(enm.ToString());
            if (mi != null && mi.Length > 0)
            {
                var attr = GetCustomAttribute(mi[0],
                    typeof(ParametersDescription)) as ParametersDescription;
                if (attr != null)
                {
                    return attr._settings;
                }
            }
            return null;
        }
    }
}