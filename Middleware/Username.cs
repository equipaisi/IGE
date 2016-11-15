using System;
using System.Collections.Generic;
using System.Linq;

namespace Middleware
{
    //TODO: class PasswordPolicy => Lista de Predicados?
    //politica de mudar de password de x em x tempo

    public static class Username
    {
        // TODO: develop this?
        public static bool Valid(string username) => !string.IsNullOrWhiteSpace(username);

        public static bool ComplexValid(string username, IEnumerable<Predicate<string>> predicates)
            => Valid(username) && predicates.All(pred => pred(username));
    }
}
