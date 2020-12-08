using Microsoft.AspNetCore.Http;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace WebMarket.Helpers
{
    public static class ExtensionHelper
    {
        public static string ToVnd(this double giaTri)
        {
            return $"{giaTri:#,##0.00} đ";
        }

        public static void Set<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T Get<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default : JsonSerializer.Deserialize<T>(value);
        }
        public static string RemoveDiacritics(this string text,int id)
        {
            if (string.IsNullOrWhiteSpace(text))
                return text;
            string newtext="";
            for(int i=0; i < text.Length; i++)
            {
                if(text[i]!=' ')
                {
                    newtext += text[i];
                }
            }
            newtext += id;
            newtext = newtext.Normalize(NormalizationForm.FormD);
            var chars = newtext.Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark).ToArray();
            return new string(chars).Normalize(NormalizationForm.FormC);

        }
    }
}