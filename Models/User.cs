using System.ComponentModel.DataAnnotations;
namespace DojoSurvey.Models;
#pragma warning disable CS8618

public class User
{
    public string Name {get; set;}

    public string Location {get; set;}

    public int Language {get; set;}

    public string Comment {get;set;}
}