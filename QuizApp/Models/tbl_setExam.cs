//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuizApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_setExam
    {
        public int examId { get; set; }
        public Nullable<System.DateTime> exam_date { get; set; }
        public Nullable<int> exam_fk_stu { get; set; }
        public string exam_name { get; set; }
        public Nullable<int> std_score { get; set; }
        public Nullable<int> exam_fk_cat__id { get; set; }
    
        public virtual student student { get; set; }
    }
}
