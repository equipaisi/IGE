using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middleware
{
    //TODO: class PasswordPolicy => Lista de Predicados?
    //politica de mudar de password de x em x tempo

    public static class Username
    {
        public static bool Valid(string username)
        {
            // TODO: develop this?
            return !string.IsNullOrWhiteSpace(username);
        }

        public static bool ComplexValid(string username, IEnumerable<Predicate<string>> predicates)
        {
            return Username.Valid(username) && predicates.All(pred => pred(username));
        }
    }
}
