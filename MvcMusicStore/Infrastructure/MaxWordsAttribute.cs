using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Infrastructure
{
    /// <summary>
    /// 自定义注解
    /// 第6、8章使用
    /// 第8章介绍添加客户端验证能力
    /// </summary>
    public class MaxWordsAttribute:ValidationAttribute
    {
        
        public MaxWordsAttribute(int maxWords):base("{0} has too many words")
        {
            _maxWords = maxWords;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var valueAsString = value.ToString();
                //字符串数量
                if (valueAsString.Split(' ').Length > _maxWords)
                {
                    var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errorMessage);
                }
            }
            return ValidationResult.Success;
        }
        private readonly int _maxWords;
    }
}