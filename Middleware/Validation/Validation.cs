using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middleware.Validation
{
    public abstract class Notification
    {
        public string Message { get; set; }
    }

    public abstract class IValidationRule<T>
    {
        public Predicate<T> Rule { get; }
        private Notification _errorMessage;

        protected IValidationRule(Predicate<T> rule, Notification errorMessage)
        {
            Rule = rule;
            _errorMessage = errorMessage;
        }

        public Notification Valid(T obj)
        {
            return !Rule(obj) ? _errorMessage : null;
        }
    }

    public abstract class Validator<T>
    {
        protected IEnumerable<IValidationRule<T>> Validators = new List<IValidationRule<T>>();

        public virtual bool Valid(T obj) => Validators.All(pred => pred.Rule(obj));
    }

    /*
    public class UsernameValidator : Validator<string>
    {
        public UsernameValidator()
        {
            Validators = new List<IValidationRule<string>> {MinimumUsernameLength};
        }

        private static bool MinimumUsernameLength(string username) => username.Length >= 8;
    }*/
}
