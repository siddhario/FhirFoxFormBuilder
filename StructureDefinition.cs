using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FhirFoxFormBuilder
{
    public class StructureDefinition
    {
        public string resourceType { get; set; }
        public string id { get; set; }
        public Text text { get; set; }
        public string url { get; set; }
        public string name { get; set; }
        public string publisher { get; set; }
        public Contact[] contact { get; set; }
        public string description { get; set; }
        public string status { get; set; }
        public string date { get; set; }
        public Mapping2[] mapping { get; set; }
        public string type { get; set; }

        [JsonProperty("abstract")]
        public bool _abstract { get; set; }

        [JsonProperty("base")]
        public string _base { get; set; }
        public Snapshot snapshot { get; set; }
        public Differential differential { get; set; }
    }

    public class Text
    {
        public string status { get; set; }
        public string div { get; set; }
    }

    public class Snapshot
    {
        public Element[] element { get; set; }
        
    }

    public class Element
    {
        public string path { get; set; }
        public string name { get; set; }

        [JsonProperty("short")]
        public string _short { get; set; }
        public string definition { get; set; }
        public int min { get; set; }
        public string max { get; set; }
        public Type[] type { get; set; }
        public Constraint[] constraint { get; set; }
        public Mapping[] mapping { get; set; }
        public string comments { get; set; }
        public bool isModifier { get; set; }
        public Binding binding { get; set; }
        public string[] alias { get; set; }
        public string[] condition { get; set; }
        public string requirements { get; set; }
        public bool mustSupport { get; set; }
        public bool isSummary { get; set; }
        public string[] representation { get; set; }
        public Slicing slicing { get; set; }
        public string exampleCode { get; set; }
        public string exampleString { get; set; }
        public Exampleperiod examplePeriod { get; set; }
        public bool defaultValueBoolean { get; set; }
    }

    public class Binding
    {
        public string name { get; set; }
        public string strength { get; set; }
        public string description { get; set; }
        public string valueSetUri { get; set; }
        public Valuesetreference valueSetReference { get; set; }
    }

    public class Valuesetreference
    {
        public string reference { get; set; }
    }

    public class Slicing
    {
        public string[] discriminator { get; set; }
        public bool ordered { get; set; }
        public string rules { get; set; }
    }

    public class Exampleperiod
    {
        public string start { get; set; }
        public string end { get; set; }
    }

    public class Type
    {
        public string code { get; set; }
        public string profile { get; set; }
    }

    public class Constraint
    {
        public string key { get; set; }
        public string name { get; set; }
        public string severity { get; set; }
        public string human { get; set; }
        public string xpath { get; set; }
    }

    public class Mapping
    {
        public string identity { get; set; }
        public string map { get; set; }
    }

    public class Differential
    {
        public Element1[] element { get; set; }
    }

    public class Element1
    {
        public string path { get; set; }
        public string name { get; set; }
        public int min { get; set; }
        public string max { get; set; }
        public Type1[] type { get; set; }
        public Mapping1[] mapping { get; set; }
        public bool mustSupport { get; set; }
        public Slicing1 slicing { get; set; }

        [JsonProperty("short")]
        public string _short { get; set; }
        public string definition { get; set; }
        public Binding1 binding { get; set; }
    }

    public class Slicing1
    {
        public string[] discriminator { get; set; }
        public bool ordered { get; set; }
        public string rules { get; set; }
    }

    public class Binding1
    {
        public string name { get; set; }
        public string strength { get; set; }
        public string description { get; set; }
        public Valuesetreference1 valueSetReference { get; set; }
    }

    public class Valuesetreference1
    {
        public string reference { get; set; }
    }

    public class Type1
    {
        public string code { get; set; }
        public string profile { get; set; }
    }

    public class Mapping1
    {
        public string identity { get; set; }
        public string map { get; set; }
    }

    public class Contact
    {
        public Telecom[] telecom { get; set; }
    }

    public class Telecom
    {
        public string system { get; set; }
        public string value { get; set; }
    }

    public class Mapping2
    {
        public string identity { get; set; }
        public string uri { get; set; }
        public string name { get; set; }
    }

}
