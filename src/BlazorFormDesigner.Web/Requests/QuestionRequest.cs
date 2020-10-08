using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BlazorFormDesigner.Web.Requests
{
    public class QuestionRequest
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public QuestionType Type { get; set; }

        public bool IsCorrected { get; set; }

        public List<OptionRequest> Options { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum QuestionType
    {
        [EnumMember(Value = "Text question")]
        Text,
        [EnumMember(Value = "Numeric question")]
        Numeric,
        [EnumMember(Value = "Binary question")]
        Binary,
        [EnumMember(Value = "Single chioce question")]
        SingleChoice,
        [EnumMember(Value = "Multiple chioce question")]
        MultipleChoice
    }
}
