This folder holds wrappers for CUnify as sub projects because the wrapper code is so bulky on each version.

*****If you get compile errors, check the FAQ, or check to see if the WSDL has System() properties that conflict with Global.System namespace

*****IF you make any changes to the WSDLS(update, change name etc)
Open up the generated VB file and replace:
Inherits System.Web.Services.Protocols.SoapHttpClientProtocol 
with
Inherits Microsoft.Web.Services3.WebServicesClientProtocol


Please refer to here for more detail on setup:

https://intranet/Projects/LoansPQ_Developer%27s_Corner/Project_Descriptions#Wrapper_Projects