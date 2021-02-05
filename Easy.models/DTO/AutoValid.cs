using Easy.Util;
using Easy.Util.Judge;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace Easy.models.DTO
{
    /// <summary>
    /// 校验基类
    /// </summary>
    public class AutoValid : IValidatableObject
    {
        /// <summary>
        /// 自动非空校验
        /// </summary>
        /// <param name="validationContext"></param>
        /// <returns></returns>
        public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            Type type = this.GetType();
            foreach (PropertyInfo p in type.GetProperties())
            {
                var fildType = p.PropertyType.Name;
                switch (fildType)
                {
                    case "String":
                        if (p.GetValue(this).ToString().IsEmpty())
                        {
                            yield return new ValidationResult($"{p.Name}不可为空！ ");
                        }
                        break;
                    case "Int":
                    case "Int32":
                    case "Int64":
                        if (p.GetValue(this).ToInt32() == 0)
                        {
                            yield return new ValidationResult($"{p.Name}不可为空！ ");
                        }
                        break;
                    case "DateTime":
                        if (p.GetValue(this).ToString().ToDatetime() == DateTime.MinValue)
                        {
                            yield return new ValidationResult($"{p.Name}不可为空！ ");
                        }
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
