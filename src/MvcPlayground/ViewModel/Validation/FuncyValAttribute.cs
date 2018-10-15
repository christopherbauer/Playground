using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcPlayground.ViewModel.Validation
{
//    public class FuncyValAttribute<T> : ValidationAttribute where T : class
//    {
//        private readonly Func<T, bool> _func;
//
//        public FuncyValAttribute(Func<T, bool> func)
//        {
//            _func = func;
//        }
//
//        public override bool RequiresValidationContext
//        {
//            get { return true; }
//        }
//
//        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
//        {
//            if(value == null) return ValidationResult.Success;
//            
//            var tValue = value as T;
//            
//            if (_func(tValue))
//            {
//                return ValidationResult.Success;
//            }
//            return new ValidationResult("Error");
//        }
//    }
}