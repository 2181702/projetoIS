namespace ClientForm
{
    public abstract class InputType
    {
        public abstract Response<string> Run();
    }


    public abstract class OutputType
    {
        public abstract Response<string> Run(Response<string> json);
        
    }
}