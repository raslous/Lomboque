using System.Text.RegularExpressions;

namespace Lomboque.Domain.Common.Helpers
{
    public static class Extension
    {
        static public string UpperCaseFirstCharacter(this string text) {
            return Regex.Replace(text, "^[a-z]", m => m.Value.ToUpper());
        }

        static public string Short(this Guid guid){
            string uid = Convert.ToBase64String(guid.ToByteArray());
            return Regex.Replace(uid, "[/+=]", "");
        }
    }
}