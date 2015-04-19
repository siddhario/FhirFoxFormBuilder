using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FhirFoxFormBuilder
{
    class Program
    {
        static  void Main(string[] args)
        {
            var local = false;
            var path = "..\\..\\data\\org-daf-daforganization.profile.json";
             var strucDefUrl = "http://hl7.org/fhir/2015May/org-daf-daforganization.profile.json";
             strucDefUrl = "http://hl7.org/fhir/2015May/patient-daf-dafpatient.profile.json";
           // strucDefUrl = "http://hl7.org/fhir/2015May/medication-daf-dafmedication.profile.json";
           // strucDefUrl = "http://hl7.org/fhir/2015May/allergyintolerance-daf-dafallergyintolerance.profile.json";
            //strucDefUrl = "http://hl7.org/fhir/2015May/medicationdispense-daf-dafmedicationdispense.profile.json";
            
            string strucDefJson = null;

            if (local == true)
            {             
                StreamReader sr = new StreamReader(path);
                strucDefJson = sr.ReadToEnd();
            }
            else
            {             
                HttpClient client = new HttpClient();
                Task<string> strucDefTask = client.GetStringAsync(strucDefUrl);
                strucDefTask.Wait();
                strucDefJson = strucDefTask.Result;
            }

            StructureDefinition strucDef = JsonConvert.DeserializeObject<StructureDefinition>(strucDefJson);
         

            UI code = new UI(strucDef);

            var codeFile = @"C:\FhirFox\codegen\"+strucDef.name+".html";
            StreamWriter sw = new StreamWriter(codeFile);
            sw.Write(code.TransformText());
            sw.Close();

            Process.Start(codeFile);
        }
    }
}
