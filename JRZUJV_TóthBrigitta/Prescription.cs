//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JRZUJV_TóthBrigitta
{
    using System;
    using System.Collections.Generic;
    
    public partial class Prescription
    {
        public int PrescriptionID { get; set; }
        public int PatientID_FK { get; set; }
        public int MedicationID_FK { get; set; }
    
        public virtual Medication Medication { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
