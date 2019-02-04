using System;
using System.ComponentModel.DataAnnotations;
namespace CoreProject.Models
{
    public class Person
    {
        [Display(Name="Имя")]
        public string Name{get;set;}
        [Display(Name="Дата")]
        [DisplayFormat(DataFormatString="{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date{get;set;}

    }
}