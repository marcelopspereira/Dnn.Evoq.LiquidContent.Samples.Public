﻿using Newtonsoft.Json;
using StructuredContent.Models.ContentTypeFields.Validation;

namespace StructuredContent.Models.ContentTypeFields.SingleLineText
{
    [JsonObject]
    public class  SingleLineTextValidation : BaseFieldValidation
    {
        public RequireFieldValidation RequireField { get; set; } = new RequireFieldValidation();
        public RangeValidation NumberOfCharacters { get; set; } = new RangeValidation();
    }
}
