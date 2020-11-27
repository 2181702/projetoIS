# projetoIS

## Response
**class Response<T>**
Usar esta class para comunicação entre diferentes handlers (ExcelHandler, XmlHandler)
constructores can be :

public Response(T Data, string Message, STATUS_CODE Status)
public Response(T Data,STATUS_CODE Status)
public Response()

##### Properties
  **DATA**
  
    This is the main data to send, it can be of any time, most of the time use Response<string> since json is in a string
    This can be anything, it's a generic!
  **MESSAGE**
  
    This is the propertie to send a message, this usually is what is shown to the user in case of a error
  **STATUS**
  
    Use the enum SATUS_CODE to send diferent satus, feel free to add aditional status codes, use STATUS_CODE.OK when everything is ok, and for erros use STATUS_CODE.ERROR
    Aditional codes can be used to diferenciate special edge cases.
#### Exemples
*Returning*

  **Everything is ok**
  
    return new Response<string>(jsonString,"Everything is ok!",STATUS_CODE.OK);
  **Everything is wrong**
  
    return new Response<string>("","Everything went wrong!",STATUS_CODE.ERROR);

*Declaring a function that returns a response*
    
    public Response<string> MyFunction(){
      return new Response<string>();
    }
