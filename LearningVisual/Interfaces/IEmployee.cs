namespace LearningVisual.Interfaces;

internal interface IEmployee : IBaseEmployee

{

    IBaseEmployee Manager { get; set; }  

}



