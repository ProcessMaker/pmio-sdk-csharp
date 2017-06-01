# ProcessMaker.PMIO.Api.ProcessmakerApi

All URIs are relative to *https://CHANGEME.api.processmaker.io/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddClient**](ProcessmakerApi.md#addclient) | **POST** /users/{user_id}/clients | 
[**AddEvent**](ProcessmakerApi.md#addevent) | **POST** /processes/{process_id}/events | 
[**AddEventConnector**](ProcessmakerApi.md#addeventconnector) | **POST** /processes/{process_id}/events/{event_id}/connectors | 
[**AddFlow**](ProcessmakerApi.md#addflow) | **POST** /processes/{process_id}/flows | 
[**AddGateway**](ProcessmakerApi.md#addgateway) | **POST** /processes/{process_id}/gateways | 
[**AddGroup**](ProcessmakerApi.md#addgroup) | **POST** /groups | 
[**AddGroupsToTask**](ProcessmakerApi.md#addgroupstotask) | **PUT** /processes/{process_id}/tasks/{task_id}/groups | 
[**AddInputOutput**](ProcessmakerApi.md#addinputoutput) | **POST** /processes/{process_id}/tasks/{task_id}/inputoutput | 
[**AddInstance**](ProcessmakerApi.md#addinstance) | **POST** /processes/{process_id}/instances | 
[**AddProcess**](ProcessmakerApi.md#addprocess) | **POST** /processes | 
[**AddTask**](ProcessmakerApi.md#addtask) | **POST** /processes/{process_id}/tasks | 
[**AddTaskConnector**](ProcessmakerApi.md#addtaskconnector) | **POST** /processes/{process_id}/tasks/{task_id}/connectors | 
[**AddUser**](ProcessmakerApi.md#adduser) | **POST** /users | 
[**AddUsersToGroup**](ProcessmakerApi.md#adduserstogroup) | **PUT** /groups/{id}/users | 
[**DeleteClient**](ProcessmakerApi.md#deleteclient) | **DELETE** /users/{user_id}/clients/{client_id} | 
[**DeleteEvent**](ProcessmakerApi.md#deleteevent) | **DELETE** /processes/{process_id}/events/{event_id} | 
[**DeleteEventConnector**](ProcessmakerApi.md#deleteeventconnector) | **DELETE** /processes/{process_id}/events/{event_id}/connectors/{connector_id} | 
[**DeleteFlow**](ProcessmakerApi.md#deleteflow) | **DELETE** /processes/{process_id}/flows/{flow_id} | 
[**DeleteGateway**](ProcessmakerApi.md#deletegateway) | **DELETE** /processes/{process_id}/gateways/{gateway_id} | 
[**DeleteGroup**](ProcessmakerApi.md#deletegroup) | **DELETE** /groups/{id} | 
[**DeleteInputOutput**](ProcessmakerApi.md#deleteinputoutput) | **DELETE** /processes/{process_id}/tasks/{task_id}/inputoutput/{inputoutput_uid} | 
[**DeleteInstance**](ProcessmakerApi.md#deleteinstance) | **DELETE** /processes/{process_id}/instances/{instance_id} | 
[**DeleteProcess**](ProcessmakerApi.md#deleteprocess) | **DELETE** /processes/{id} | 
[**DeleteTask**](ProcessmakerApi.md#deletetask) | **DELETE** /processes/{process_id}/tasks/{task_id} | 
[**DeleteTaskConnector**](ProcessmakerApi.md#deletetaskconnector) | **DELETE** /processes/{process_id}/tasks/{task_id}/connectors/{connector_id} | 
[**DeleteUser**](ProcessmakerApi.md#deleteuser) | **DELETE** /users/{id} | 
[**EventTrigger**](ProcessmakerApi.md#eventtrigger) | **POST** /processes/{process_id}/events/{event_id}/trigger | 
[**FindClientById**](ProcessmakerApi.md#findclientbyid) | **GET** /users/{user_id}/clients/{client_id} | 
[**FindClients**](ProcessmakerApi.md#findclients) | **GET** /users/{user_id}/clients | 
[**FindDataModel**](ProcessmakerApi.md#finddatamodel) | **GET** /processes/{process_id}/instances/{instance_id}/datamodel | 
[**FindEventById**](ProcessmakerApi.md#findeventbyid) | **GET** /processes/{process_id}/events/{event_id} | 
[**FindEventConnectorById**](ProcessmakerApi.md#findeventconnectorbyid) | **GET** /processes/{process_id}/events/{event_id}/connectors/{connector_id} | 
[**FindEventConnectors**](ProcessmakerApi.md#findeventconnectors) | **GET** /processes/{process_id}/events/{event_id}/connectors | 
[**FindEvents**](ProcessmakerApi.md#findevents) | **GET** /processes/{process_id}/events | 
[**FindFlowById**](ProcessmakerApi.md#findflowbyid) | **GET** /processes/{process_id}/flows/{flow_id} | 
[**FindFlows**](ProcessmakerApi.md#findflows) | **GET** /processes/{process_id}/flows | 
[**FindGatewayById**](ProcessmakerApi.md#findgatewaybyid) | **GET** /processes/{process_id}/gateways/{gateway_id} | 
[**FindGateways**](ProcessmakerApi.md#findgateways) | **GET** /processes/{process_id}/gateways | 
[**FindGroupById**](ProcessmakerApi.md#findgroupbyid) | **GET** /groups/{id} | 
[**FindGroups**](ProcessmakerApi.md#findgroups) | **GET** /groups | 
[**FindInputOutputById**](ProcessmakerApi.md#findinputoutputbyid) | **GET** /processes/{process_id}/tasks/{task_id}/inputoutput/{inputoutput_uid} | 
[**FindInputOutputs**](ProcessmakerApi.md#findinputoutputs) | **GET** /processes/{process_id}/tasks/{task_id}/inputoutput | 
[**FindInstanceById**](ProcessmakerApi.md#findinstancebyid) | **GET** /processes/{process_id}/instances/{instance_id} | 
[**FindInstances**](ProcessmakerApi.md#findinstances) | **GET** /processes/{process_id}/instances | 
[**FindProcessById**](ProcessmakerApi.md#findprocessbyid) | **GET** /processes/{id} | 
[**FindProcesses**](ProcessmakerApi.md#findprocesses) | **GET** /processes | 
[**FindTaskById**](ProcessmakerApi.md#findtaskbyid) | **GET** /processes/{process_id}/tasks/{task_id} | 
[**FindTaskConnectorById**](ProcessmakerApi.md#findtaskconnectorbyid) | **GET** /processes/{process_id}/tasks/{task_id}/connectors/{connector_id} | 
[**FindTaskConnectors**](ProcessmakerApi.md#findtaskconnectors) | **GET** /processes/{process_id}/tasks/{task_id}/connectors | 
[**FindTaskInstanceById**](ProcessmakerApi.md#findtaskinstancebyid) | **GET** /task_instances/{task_instance_id} | 
[**FindTaskInstances**](ProcessmakerApi.md#findtaskinstances) | **GET** /task_instances | 
[**FindTasks**](ProcessmakerApi.md#findtasks) | **GET** /processes/{process_id}/tasks | 
[**FindUserById**](ProcessmakerApi.md#finduserbyid) | **GET** /users/{id} | 
[**FindUsers**](ProcessmakerApi.md#findusers) | **GET** /users | 
[**ImportBpmnFile**](ProcessmakerApi.md#importbpmnfile) | **POST** /processes/import | 
[**MyselfUser**](ProcessmakerApi.md#myselfuser) | **GET** /users/myself | 
[**RemoveGroupsFromTask**](ProcessmakerApi.md#removegroupsfromtask) | **DELETE** /processes/{process_id}/tasks/{task_id}/groups | 
[**RemoveUsersFromGroup**](ProcessmakerApi.md#removeusersfromgroup) | **DELETE** /groups/{id}/users | 
[**SyncGroupsToTask**](ProcessmakerApi.md#syncgroupstotask) | **POST** /processes/{process_id}/tasks/{task_id}/groups | 
[**SyncUsersToGroup**](ProcessmakerApi.md#syncuserstogroup) | **POST** /groups/{id}/users | 
[**UpdateClient**](ProcessmakerApi.md#updateclient) | **PUT** /users/{user_id}/clients/{client_id} | 
[**UpdateEvent**](ProcessmakerApi.md#updateevent) | **PUT** /processes/{process_id}/events/{event_id} | 
[**UpdateEventConnector**](ProcessmakerApi.md#updateeventconnector) | **PUT** /processes/{process_id}/events/{event_id}/connectors/{connector_id} | 
[**UpdateFlow**](ProcessmakerApi.md#updateflow) | **PUT** /processes/{process_id}/flows/{flow_id} | 
[**UpdateGateway**](ProcessmakerApi.md#updategateway) | **PUT** /processes/{process_id}/gateways/{gateway_id} | 
[**UpdateGroup**](ProcessmakerApi.md#updategroup) | **PUT** /groups/{id} | 
[**UpdateInputOutput**](ProcessmakerApi.md#updateinputoutput) | **PUT** /processes/{process_id}/tasks/{task_id}/inputoutput/{inputoutput_uid} | 
[**UpdateInstance**](ProcessmakerApi.md#updateinstance) | **PUT** /processes/{process_id}/instances/{instance_id} | 
[**UpdateProcess**](ProcessmakerApi.md#updateprocess) | **PUT** /processes/{id} | 
[**UpdateTask**](ProcessmakerApi.md#updatetask) | **PUT** /processes/{process_id}/tasks/{task_id} | 
[**UpdateTaskConnector**](ProcessmakerApi.md#updatetaskconnector) | **PUT** /processes/{process_id}/tasks/{task_id}/connectors/{connector_id} | 
[**UpdateTaskInstance**](ProcessmakerApi.md#updatetaskinstance) | **PATCH** /task_instances/{task_instance_id} | 
[**UpdateUser**](ProcessmakerApi.md#updateuser) | **PUT** /users/{id} | 


<a name="addclient"></a>
# **AddClient**
> ClientItem AddClient (string userId, ClientCreateItem clientCreateItem)



This method creates a new Oauth client for the user

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class AddClientExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var userId = userId_example;  // string | ID of the user related to the Oauth client
            var clientCreateItem = new ClientCreateItem(); // ClientCreateItem | JSON API with the Oauth Client object to add

            try
            {
                ClientItem result = apiInstance.AddClient(userId, clientCreateItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.AddClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| ID of the user related to the Oauth client | 
 **clientCreateItem** | [**ClientCreateItem**](ClientCreateItem.md)| JSON API with the Oauth Client object to add | 

### Return type

[**ClientItem**](ClientItem.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addevent"></a>
# **AddEvent**
> EventItem AddEvent (string processId, EventCreateItem eventCreateItem)



This method creates the new event.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class AddEventExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | ID of the process related to the event
            var eventCreateItem = new EventCreateItem(); // EventCreateItem | JSON API response with the Event object to add

            try
            {
                EventItem result = apiInstance.AddEvent(processId, eventCreateItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.AddEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| ID of the process related to the event | 
 **eventCreateItem** | [**EventCreateItem**](EventCreateItem.md)| JSON API response with the Event object to add | 

### Return type

[**EventItem**](EventItem.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addeventconnector"></a>
# **AddEventConnector**
> EventConnector1 AddEventConnector (string processId, string eventId, EventConnectorCreateItem eventConnectorCreateItem)



This method is intended for creating a new Event connector.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class AddEventConnectorExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | ID of Process to fetch
            var eventId = eventId_example;  // string | ID of Event to fetch
            var eventConnectorCreateItem = new EventConnectorCreateItem(); // EventConnectorCreateItem | JSON API with the EventConnector object to add

            try
            {
                EventConnector1 result = apiInstance.AddEventConnector(processId, eventId, eventConnectorCreateItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.AddEventConnector: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| ID of Process to fetch | 
 **eventId** | **string**| ID of Event to fetch | 
 **eventConnectorCreateItem** | [**EventConnectorCreateItem**](EventConnectorCreateItem.md)| JSON API with the EventConnector object to add | 

### Return type

[**EventConnector1**](EventConnector1.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addflow"></a>
# **AddFlow**
> FlowItem AddFlow (string processId, FlowCreateItem flowCreateItem)



This method creates a new Sequence flow

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class AddFlowExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | ID of the process related to the flow
            var flowCreateItem = new FlowCreateItem(); // FlowCreateItem | JSON API response with the Flow object to add

            try
            {
                FlowItem result = apiInstance.AddFlow(processId, flowCreateItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.AddFlow: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| ID of the process related to the flow | 
 **flowCreateItem** | [**FlowCreateItem**](FlowCreateItem.md)| JSON API response with the Flow object to add | 

### Return type

[**FlowItem**](FlowItem.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addgateway"></a>
# **AddGateway**
> GatewayItem AddGateway (string processId, GatewayCreateItem gatewayCreateItem)



This method creates a new gateway.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class AddGatewayExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | ID of the process related to the gateway
            var gatewayCreateItem = new GatewayCreateItem(); // GatewayCreateItem | JSON API response with the gateway object to add

            try
            {
                GatewayItem result = apiInstance.AddGateway(processId, gatewayCreateItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.AddGateway: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| ID of the process related to the gateway | 
 **gatewayCreateItem** | [**GatewayCreateItem**](GatewayCreateItem.md)| JSON API response with the gateway object to add | 

### Return type

[**GatewayItem**](GatewayItem.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addgroup"></a>
# **AddGroup**
> GroupItem AddGroup (GroupCreateItem groupCreateItem)



This method creates a new group.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class AddGroupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var groupCreateItem = new GroupCreateItem(); // GroupCreateItem | JSON API with the Group object to add

            try
            {
                GroupItem result = apiInstance.AddGroup(groupCreateItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.AddGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupCreateItem** | [**GroupCreateItem**](GroupCreateItem.md)| JSON API with the Group object to add | 

### Return type

[**GroupItem**](GroupItem.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addgroupstotask"></a>
# **AddGroupsToTask**
> ResultSuccess AddGroupsToTask (string processId, string taskId, TaskAddGroupsItem taskAddGroupsItem)



This method assigns group(s) to the choosen task

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class AddGroupsToTaskExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | Process ID
            var taskId = taskId_example;  // string | ID of task to be modified
            var taskAddGroupsItem = new TaskAddGroupsItem(); // TaskAddGroupsItem | JSON API with Groups ID's to add

            try
            {
                ResultSuccess result = apiInstance.AddGroupsToTask(processId, taskId, taskAddGroupsItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.AddGroupsToTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| Process ID | 
 **taskId** | **string**| ID of task to be modified | 
 **taskAddGroupsItem** | [**TaskAddGroupsItem**](TaskAddGroupsItem.md)| JSON API with Groups ID&#39;s to add | 

### Return type

[**ResultSuccess**](ResultSuccess.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addinputoutput"></a>
# **AddInputOutput**
> InputOutputItem AddInputOutput (string processId, string taskId, InputOutputCreateItem inputOutputCreateItem)



This method creates a new Input/Output object

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class AddInputOutputExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | Process ID related to Input/Output object
            var taskId = taskId_example;  // string | Task instance ID related to Input/Output object
            var inputOutputCreateItem = new InputOutputCreateItem(); // InputOutputCreateItem | Create and add a new Input/Output object with JSON API

            try
            {
                InputOutputItem result = apiInstance.AddInputOutput(processId, taskId, inputOutputCreateItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.AddInputOutput: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| Process ID related to Input/Output object | 
 **taskId** | **string**| Task instance ID related to Input/Output object | 
 **inputOutputCreateItem** | [**InputOutputCreateItem**](InputOutputCreateItem.md)| Create and add a new Input/Output object with JSON API | 

### Return type

[**InputOutputItem**](InputOutputItem.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addinstance"></a>
# **AddInstance**
> InstanceItem AddInstance (string processId, InstanceCreateItem instanceCreateItem)



This method creates a new instance.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class AddInstanceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | Process ID related to the nstance
            var instanceCreateItem = new InstanceCreateItem(); // InstanceCreateItem | JSON API response with the Instance object to add

            try
            {
                InstanceItem result = apiInstance.AddInstance(processId, instanceCreateItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.AddInstance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| Process ID related to the nstance | 
 **instanceCreateItem** | [**InstanceCreateItem**](InstanceCreateItem.md)| JSON API response with the Instance object to add | 

### Return type

[**InstanceItem**](InstanceItem.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addprocess"></a>
# **AddProcess**
> ProcessItem AddProcess (ProcessCreateItem processCreateItem)



This method creates a new process

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class AddProcessExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processCreateItem = new ProcessCreateItem(); // ProcessCreateItem | JSON API response with the Process object to add

            try
            {
                ProcessItem result = apiInstance.AddProcess(processCreateItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.AddProcess: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processCreateItem** | [**ProcessCreateItem**](ProcessCreateItem.md)| JSON API response with the Process object to add | 

### Return type

[**ProcessItem**](ProcessItem.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addtask"></a>
# **AddTask**
> TaskItem AddTask (string processId, TaskCreateItem taskCreateItem)



This method creates a new task.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class AddTaskExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | Process ID related to the task
            var taskCreateItem = new TaskCreateItem(); // TaskCreateItem | JSON API with the Task object to add

            try
            {
                TaskItem result = apiInstance.AddTask(processId, taskCreateItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.AddTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| Process ID related to the task | 
 **taskCreateItem** | [**TaskCreateItem**](TaskCreateItem.md)| JSON API with the Task object to add | 

### Return type

[**TaskItem**](TaskItem.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addtaskconnector"></a>
# **AddTaskConnector**
> TaskConnector1 AddTaskConnector (string processId, string taskId, TaskConnectorCreateItem taskConnectorCreateItem)



This method is intended for creating a new task connector.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class AddTaskConnectorExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | ID of Process to fetch
            var taskId = taskId_example;  // string | ID of Task to fetch
            var taskConnectorCreateItem = new TaskConnectorCreateItem(); // TaskConnectorCreateItem | JSON API with the TaskConnector object to add

            try
            {
                TaskConnector1 result = apiInstance.AddTaskConnector(processId, taskId, taskConnectorCreateItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.AddTaskConnector: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| ID of Process to fetch | 
 **taskId** | **string**| ID of Task to fetch | 
 **taskConnectorCreateItem** | [**TaskConnectorCreateItem**](TaskConnectorCreateItem.md)| JSON API with the TaskConnector object to add | 

### Return type

[**TaskConnector1**](TaskConnector1.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adduser"></a>
# **AddUser**
> UserItem AddUser (UserCreateItem userCreateItem)



This method creates a new user in the system.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class AddUserExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var userCreateItem = new UserCreateItem(); // UserCreateItem | JSON API with the User object to add

            try
            {
                UserItem result = apiInstance.AddUser(userCreateItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.AddUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userCreateItem** | [**UserCreateItem**](UserCreateItem.md)| JSON API with the User object to add | 

### Return type

[**UserItem**](UserItem.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="adduserstogroup"></a>
# **AddUsersToGroup**
> ResultSuccess AddUsersToGroup (string id, GroupAddUsersItem groupAddUsersItem)



This method adds one or more new users to a group.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class AddUsersToGroupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var id = id_example;  // string | ID of group to be modified
            var groupAddUsersItem = new GroupAddUsersItem(); // GroupAddUsersItem | JSON API response with array of users ID's

            try
            {
                ResultSuccess result = apiInstance.AddUsersToGroup(id, groupAddUsersItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.AddUsersToGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of group to be modified | 
 **groupAddUsersItem** | [**GroupAddUsersItem**](GroupAddUsersItem.md)| JSON API response with array of users ID&#39;s | 

### Return type

[**ResultSuccess**](ResultSuccess.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteclient"></a>
# **DeleteClient**
> ResultSuccess DeleteClient (string userId, string clientId)



This method deletes an Oauth client using the client and user IDs.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class DeleteClientExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var userId = userId_example;  // string | User ID
            var clientId = clientId_example;  // string | ID of client to delete

            try
            {
                ResultSuccess result = apiInstance.DeleteClient(userId, clientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.DeleteClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| User ID | 
 **clientId** | **string**| ID of client to delete | 

### Return type

[**ResultSuccess**](ResultSuccess.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteevent"></a>
# **DeleteEvent**
> ResultSuccess DeleteEvent (string processId, string eventId)



This method deletes an event using the event ID and process ID

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class DeleteEventExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | Process ID
            var eventId = eventId_example;  // string | ID of event to delete

            try
            {
                ResultSuccess result = apiInstance.DeleteEvent(processId, eventId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.DeleteEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| Process ID | 
 **eventId** | **string**| ID of event to delete | 

### Return type

[**ResultSuccess**](ResultSuccess.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteeventconnector"></a>
# **DeleteEventConnector**
> ResultSuccess DeleteEventConnector (string processId, string eventId, string connectorId)



This method is intended for deleting a single Event connector based on Event ID, Process ID and Connector ID.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class DeleteEventConnectorExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | ID of of Process item
            var eventId = eventId_example;  // string | ID of item to fetch
            var connectorId = connectorId_example;  // string | ID of EventConnector to fetch

            try
            {
                ResultSuccess result = apiInstance.DeleteEventConnector(processId, eventId, connectorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.DeleteEventConnector: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| ID of of Process item | 
 **eventId** | **string**| ID of item to fetch | 
 **connectorId** | **string**| ID of EventConnector to fetch | 

### Return type

[**ResultSuccess**](ResultSuccess.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteflow"></a>
# **DeleteFlow**
> ResultSuccess DeleteFlow (string processId, string flowId)



This method deletes a sequence flow using the flow ID and process ID.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class DeleteFlowExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | Process ID
            var flowId = flowId_example;  // string | ID of flow to delete

            try
            {
                ResultSuccess result = apiInstance.DeleteFlow(processId, flowId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.DeleteFlow: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| Process ID | 
 **flowId** | **string**| ID of flow to delete | 

### Return type

[**ResultSuccess**](ResultSuccess.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegateway"></a>
# **DeleteGateway**
> ResultSuccess DeleteGateway (string processId, string gatewayId)



This method is deletes a single item using the gateway ID and process ID.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class DeleteGatewayExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | Process ID
            var gatewayId = gatewayId_example;  // string | ID of Process to delete

            try
            {
                ResultSuccess result = apiInstance.DeleteGateway(processId, gatewayId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.DeleteGateway: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| Process ID | 
 **gatewayId** | **string**| ID of Process to delete | 

### Return type

[**ResultSuccess**](ResultSuccess.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegroup"></a>
# **DeleteGroup**
> ResultSuccess DeleteGroup (string id)



This method deletes a group using the group ID

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class DeleteGroupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var id = id_example;  // string | ID of group to delete

            try
            {
                ResultSuccess result = apiInstance.DeleteGroup(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.DeleteGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of group to delete | 

### Return type

[**ResultSuccess**](ResultSuccess.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinputoutput"></a>
# **DeleteInputOutput**
> ResultSuccess DeleteInputOutput (string processId, string taskId, string inputoutputUid)



This method deletes the Input/Output based on the Input/Output ID, process ID and task ID.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class DeleteInputOutputExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | Process ID related to the Input/Output object
            var taskId = taskId_example;  // string | Task instance ID related to Input/Output object
            var inputoutputUid = inputoutputUid_example;  // string | Input/Output ID to fetch

            try
            {
                ResultSuccess result = apiInstance.DeleteInputOutput(processId, taskId, inputoutputUid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.DeleteInputOutput: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| Process ID related to the Input/Output object | 
 **taskId** | **string**| Task instance ID related to Input/Output object | 
 **inputoutputUid** | **string**| Input/Output ID to fetch | 

### Return type

[**ResultSuccess**](ResultSuccess.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinstance"></a>
# **DeleteInstance**
> ResultSuccess DeleteInstance (string processId, string instanceId)



This method deletes an instance using the instance ID and process ID.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class DeleteInstanceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | Process ID
            var instanceId = instanceId_example;  // string | ID of instance to delete

            try
            {
                ResultSuccess result = apiInstance.DeleteInstance(processId, instanceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.DeleteInstance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| Process ID | 
 **instanceId** | **string**| ID of instance to delete | 

### Return type

[**ResultSuccess**](ResultSuccess.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteprocess"></a>
# **DeleteProcess**
> ResultSuccess DeleteProcess (string id)



This method deletes a process using the process ID.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class DeleteProcessExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var id = id_example;  // string | Process ID to delete

            try
            {
                ResultSuccess result = apiInstance.DeleteProcess(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.DeleteProcess: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Process ID to delete | 

### Return type

[**ResultSuccess**](ResultSuccess.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetask"></a>
# **DeleteTask**
> ResultSuccess DeleteTask (string processId, string taskId)



This method deletes a task using the task ID and process ID.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class DeleteTaskExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | Process ID
            var taskId = taskId_example;  // string | ID of task to delete

            try
            {
                ResultSuccess result = apiInstance.DeleteTask(processId, taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.DeleteTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| Process ID | 
 **taskId** | **string**| ID of task to delete | 

### Return type

[**ResultSuccess**](ResultSuccess.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetaskconnector"></a>
# **DeleteTaskConnector**
> ResultSuccess DeleteTaskConnector (string processId, string taskId, string connectorId)



This method is intended for deleting a single Task connector based on Task ID, Process ID and Connector ID.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class DeleteTaskConnectorExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | ID of Process item to fetch
            var taskId = taskId_example;  // string | ID of Task item to fetch
            var connectorId = connectorId_example;  // string | ID of TaskConnector to fetch

            try
            {
                ResultSuccess result = apiInstance.DeleteTaskConnector(processId, taskId, connectorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.DeleteTaskConnector: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| ID of Process item to fetch | 
 **taskId** | **string**| ID of Task item to fetch | 
 **connectorId** | **string**| ID of TaskConnector to fetch | 

### Return type

[**ResultSuccess**](ResultSuccess.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteuser"></a>
# **DeleteUser**
> ResultSuccess DeleteUser (string id)



This method deletes a user from the system.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class DeleteUserExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var id = id_example;  // string | ID of user to delete

            try
            {
                ResultSuccess result = apiInstance.DeleteUser(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.DeleteUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of user to delete | 

### Return type

[**ResultSuccess**](ResultSuccess.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventtrigger"></a>
# **EventTrigger**
> DataModelItem1 EventTrigger (string processId, string eventId, TriggerEventCreateItem triggerEventCreateItem)



This method starts/triggers an event.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class EventTriggerExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | Process ID related to the event
            var eventId = eventId_example;  // string | ID of event to trigger
            var triggerEventCreateItem = new TriggerEventCreateItem(); // TriggerEventCreateItem | Json with some parameters

            try
            {
                DataModelItem1 result = apiInstance.EventTrigger(processId, eventId, triggerEventCreateItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.EventTrigger: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| Process ID related to the event | 
 **eventId** | **string**| ID of event to trigger | 
 **triggerEventCreateItem** | [**TriggerEventCreateItem**](TriggerEventCreateItem.md)| Json with some parameters | 

### Return type

[**DataModelItem1**](DataModelItem1.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findclientbyid"></a>
# **FindClientById**
> ClientItem FindClientById (string userId, string clientId)



This method is retrieves an Oauth client based on its ID.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class FindClientByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var userId = userId_example;  // string | ID of user to retrieve
            var clientId = clientId_example;  // string | ID of client to retrieve

            try
            {
                ClientItem result = apiInstance.FindClientById(userId, clientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.FindClientById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| ID of user to retrieve | 
 **clientId** | **string**| ID of client to retrieve | 

### Return type

[**ClientItem**](ClientItem.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findclients"></a>
# **FindClients**
> ClientCollection FindClients (string userId, int? pagefindProcessById = null, int? perPage = null)



This method retrieves all existing clients belonging to an user.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class FindClientsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var userId = userId_example;  // string | User ID related to the clients
            var pagefindProcessById = 56;  // int? | Page numbers to fetch (optional)  (default to 1)
            var perPage = 56;  // int? | Amount of items per page (optional)  (default to 15)

            try
            {
                ClientCollection result = apiInstance.FindClients(userId, pagefindProcessById, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.FindClients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| User ID related to the clients | 
 **pagefindProcessById** | **int?**| Page numbers to fetch | [optional] [default to 1]
 **perPage** | **int?**| Amount of items per page | [optional] [default to 15]

### Return type

[**ClientCollection**](ClientCollection.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="finddatamodel"></a>
# **FindDataModel**
> DataModelItem1 FindDataModel (string processId, string instanceId, int? page = null, int? perPage = null)



This method returns the instance DataModel and lets the user work with it directly

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class FindDataModelExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | ID of process to return
            var instanceId = instanceId_example;  // string | ID of instance to return
            var page = 56;  // int? | Page number to fetch (optional)  (default to 1)
            var perPage = 56;  // int? | Amount of items per Page (optional)  (default to 15)

            try
            {
                DataModelItem1 result = apiInstance.FindDataModel(processId, instanceId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.FindDataModel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| ID of process to return | 
 **instanceId** | **string**| ID of instance to return | 
 **page** | **int?**| Page number to fetch | [optional] [default to 1]
 **perPage** | **int?**| Amount of items per Page | [optional] [default to 15]

### Return type

[**DataModelItem1**](DataModelItem1.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findeventbyid"></a>
# **FindEventById**
> EventItem FindEventById (string processId, string eventId)



This method retrieves an event using its ID.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class FindEventByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | ID of process to return
            var eventId = eventId_example;  // string | ID of event to return

            try
            {
                EventItem result = apiInstance.FindEventById(processId, eventId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.FindEventById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| ID of process to return | 
 **eventId** | **string**| ID of event to return | 

### Return type

[**EventItem**](EventItem.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findeventconnectorbyid"></a>
# **FindEventConnectorById**
> EventConnector1 FindEventConnectorById (string processId, string eventId, string connectorId)



This method returns all Event connectors related to the run Process and Event.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class FindEventConnectorByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | ID of Process to fetch
            var eventId = eventId_example;  // string | ID of Event to fetch
            var connectorId = connectorId_example;  // string | ID of EventConnector to fetch

            try
            {
                EventConnector1 result = apiInstance.FindEventConnectorById(processId, eventId, connectorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.FindEventConnectorById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| ID of Process to fetch | 
 **eventId** | **string**| ID of Event to fetch | 
 **connectorId** | **string**| ID of EventConnector to fetch | 

### Return type

[**EventConnector1**](EventConnector1.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findeventconnectors"></a>
# **FindEventConnectors**
> EventConnectorsCollection FindEventConnectors (string processId, string eventId, int? page = null, int? perPage = null)



This method returns all Event connectors related to the run Process and Event.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class FindEventConnectorsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | ID of Process to fetch
            var eventId = eventId_example;  // string | ID of Task to fetch
            var page = 56;  // int? | Page number to fetch (optional)  (default to 1)
            var perPage = 56;  // int? | Amount of items per Page (optional)  (default to 15)

            try
            {
                EventConnectorsCollection result = apiInstance.FindEventConnectors(processId, eventId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.FindEventConnectors: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| ID of Process to fetch | 
 **eventId** | **string**| ID of Task to fetch | 
 **page** | **int?**| Page number to fetch | [optional] [default to 1]
 **perPage** | **int?**| Amount of items per Page | [optional] [default to 15]

### Return type

[**EventConnectorsCollection**](EventConnectorsCollection.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findevents"></a>
# **FindEvents**
> EventCollection FindEvents (string processId, int? page = null, int? perPage = null)



This method returns all events related to the runned process

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class FindEventsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | ID of process related to the event
            var page = 56;  // int? | Page numbers to fetch (optional)  (default to 1)
            var perPage = 56;  // int? | Amount of items per Page (optional)  (default to 15)

            try
            {
                EventCollection result = apiInstance.FindEvents(processId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.FindEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| ID of process related to the event | 
 **page** | **int?**| Page numbers to fetch | [optional] [default to 1]
 **perPage** | **int?**| Amount of items per Page | [optional] [default to 15]

### Return type

[**EventCollection**](EventCollection.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findflowbyid"></a>
# **FindFlowById**
> FlowItem FindFlowById (string processId, string flowId)



This method retrieves a flow based on its ID.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class FindFlowByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | ID of process to return
            var flowId = flowId_example;  // string | ID of flow to return

            try
            {
                FlowItem result = apiInstance.FindFlowById(processId, flowId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.FindFlowById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| ID of process to return | 
 **flowId** | **string**| ID of flow to return | 

### Return type

[**FlowItem**](FlowItem.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findflows"></a>
# **FindFlows**
> FlowCollection FindFlows (string processId, int? page = null, int? perPage = null)



This method retrieves all existing flows.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class FindFlowsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | ID of process related to the flow
            var page = 56;  // int? | Page numbers to fetch (optional)  (default to 1)
            var perPage = 56;  // int? | Amount of items per Page (optional)  (default to 15)

            try
            {
                FlowCollection result = apiInstance.FindFlows(processId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.FindFlows: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| ID of process related to the flow | 
 **page** | **int?**| Page numbers to fetch | [optional] [default to 1]
 **perPage** | **int?**| Amount of items per Page | [optional] [default to 15]

### Return type

[**FlowCollection**](FlowCollection.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findgatewaybyid"></a>
# **FindGatewayById**
> GatewayItem FindGatewayById (string processId, string gatewayId)



This method retrieves a gateway based on its ID.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class FindGatewayByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | ID of process to return
            var gatewayId = gatewayId_example;  // string | ID of gateway to return

            try
            {
                GatewayItem result = apiInstance.FindGatewayById(processId, gatewayId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.FindGatewayById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| ID of process to return | 
 **gatewayId** | **string**| ID of gateway to return | 

### Return type

[**GatewayItem**](GatewayItem.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findgateways"></a>
# **FindGateways**
> GatewayCollection FindGateways (string processId, int? page = null, int? perPage = null)



This method retrieves all existing gateways.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class FindGatewaysExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | ID of process related to the gateway
            var page = 56;  // int? | Page number to fetch (optional)  (default to 1)
            var perPage = 56;  // int? | Amount of items per page (optional)  (default to 15)

            try
            {
                GatewayCollection result = apiInstance.FindGateways(processId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.FindGateways: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| ID of process related to the gateway | 
 **page** | **int?**| Page number to fetch | [optional] [default to 1]
 **perPage** | **int?**| Amount of items per page | [optional] [default to 15]

### Return type

[**GatewayCollection**](GatewayCollection.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findgroupbyid"></a>
# **FindGroupById**
> GroupItem FindGroupById (string id)



This method retrieves a group using its ID.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class FindGroupByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var id = id_example;  // string | ID of group to return

            try
            {
                GroupItem result = apiInstance.FindGroupById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.FindGroupById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of group to return | 

### Return type

[**GroupItem**](GroupItem.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findgroups"></a>
# **FindGroups**
> GroupCollection FindGroups (int? page = null, int? perPage = null)



This method retrieves all existing groups.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class FindGroupsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var page = 56;  // int? | Page number to fetch (optional)  (default to 1)
            var perPage = 56;  // int? | Amount of items per Page (optional)  (default to 15)

            try
            {
                GroupCollection result = apiInstance.FindGroups(page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.FindGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Page number to fetch | [optional] [default to 1]
 **perPage** | **int?**| Amount of items per Page | [optional] [default to 15]

### Return type

[**GroupCollection**](GroupCollection.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findinputoutputbyid"></a>
# **FindInputOutputById**
> InputOutputItem FindInputOutputById (string processId, string taskId, string inputoutputUid)



This method retrieves an Input/Output object using its ID.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class FindInputOutputByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | Process ID related to the Input/Output object
            var taskId = taskId_example;  // string | Task instance ID related to the Input/Output object
            var inputoutputUid = inputoutputUid_example;  // string | ID of Input/Output to return

            try
            {
                InputOutputItem result = apiInstance.FindInputOutputById(processId, taskId, inputoutputUid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.FindInputOutputById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| Process ID related to the Input/Output object | 
 **taskId** | **string**| Task instance ID related to the Input/Output object | 
 **inputoutputUid** | **string**| ID of Input/Output to return | 

### Return type

[**InputOutputItem**](InputOutputItem.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findinputoutputs"></a>
# **FindInputOutputs**
> InputOutputCollection FindInputOutputs (string processId, string taskId, int? page = null, int? perPage = null)



This method retrieves all existing Input/Output objects in the related task instance.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class FindInputOutputsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | Process ID related to Input/Output object
            var taskId = taskId_example;  // string | Task instance ID related to Input/Output object
            var page = 56;  // int? | Page number to fetch (optional)  (default to 1)
            var perPage = 56;  // int? | Amount of items per page (optional)  (default to 15)

            try
            {
                InputOutputCollection result = apiInstance.FindInputOutputs(processId, taskId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.FindInputOutputs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| Process ID related to Input/Output object | 
 **taskId** | **string**| Task instance ID related to Input/Output object | 
 **page** | **int?**| Page number to fetch | [optional] [default to 1]
 **perPage** | **int?**| Amount of items per page | [optional] [default to 15]

### Return type

[**InputOutputCollection**](InputOutputCollection.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findinstancebyid"></a>
# **FindInstanceById**
> InstanceItem FindInstanceById (string processId, string instanceId)



This method retrieves an instance using its ID.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class FindInstanceByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | ID of process to return
            var instanceId = instanceId_example;  // string | ID of instance to return

            try
            {
                InstanceItem result = apiInstance.FindInstanceById(processId, instanceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.FindInstanceById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| ID of process to return | 
 **instanceId** | **string**| ID of instance to return | 

### Return type

[**InstanceItem**](InstanceItem.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findinstances"></a>
# **FindInstances**
> InstanceCollection FindInstances (string processId, int? page = null, int? perPage = null)



This method retrieves related to the process using  the Process ID

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class FindInstancesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | Process ID related to the instances
            var page = 56;  // int? | Page number to fetch (optional)  (default to 1)
            var perPage = 56;  // int? | Amount of items per page (optional)  (default to 15)

            try
            {
                InstanceCollection result = apiInstance.FindInstances(processId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.FindInstances: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| Process ID related to the instances | 
 **page** | **int?**| Page number to fetch | [optional] [default to 1]
 **perPage** | **int?**| Amount of items per page | [optional] [default to 15]

### Return type

[**InstanceCollection**](InstanceCollection.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findprocessbyid"></a>
# **FindProcessById**
> ProcessItem FindProcessById (string id)



This method retrieves a process using its ID

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class FindProcessByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var id = id_example;  // string | ID of process to return

            try
            {
                ProcessItem result = apiInstance.FindProcessById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.FindProcessById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of process to return | 

### Return type

[**ProcessItem**](ProcessItem.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findprocesses"></a>
# **FindProcesses**
> ProcessCollection FindProcesses (int? page = null, int? perPage = null)



This method retrieves all existing processes.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class FindProcessesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var page = 56;  // int? | Page number to fetch (optional)  (default to 1)
            var perPage = 56;  // int? | Amount of items per page (optional)  (default to 15)

            try
            {
                ProcessCollection result = apiInstance.FindProcesses(page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.FindProcesses: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Page number to fetch | [optional] [default to 1]
 **perPage** | **int?**| Amount of items per page | [optional] [default to 15]

### Return type

[**ProcessCollection**](ProcessCollection.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findtaskbyid"></a>
# **FindTaskById**
> TaskItem FindTaskById (string processId, string taskId)



This method is retrieves a task using its ID.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class FindTaskByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | ID of process to return
            var taskId = taskId_example;  // string | ID of task to return

            try
            {
                TaskItem result = apiInstance.FindTaskById(processId, taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.FindTaskById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| ID of process to return | 
 **taskId** | **string**| ID of task to return | 

### Return type

[**TaskItem**](TaskItem.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findtaskconnectorbyid"></a>
# **FindTaskConnectorById**
> TaskConnector1 FindTaskConnectorById (string processId, string taskId, string connectorId)



This method is intended for retrieving an Task connector based on it's ID.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class FindTaskConnectorByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | ID of Process to fetch
            var taskId = taskId_example;  // string | ID of Task to fetch
            var connectorId = connectorId_example;  // string | ID of TaskConnector to fetch

            try
            {
                TaskConnector1 result = apiInstance.FindTaskConnectorById(processId, taskId, connectorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.FindTaskConnectorById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| ID of Process to fetch | 
 **taskId** | **string**| ID of Task to fetch | 
 **connectorId** | **string**| ID of TaskConnector to fetch | 

### Return type

[**TaskConnector1**](TaskConnector1.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findtaskconnectors"></a>
# **FindTaskConnectors**
> TaskConnectorsCollection FindTaskConnectors (string processId, string taskId, int? page = null, int? perPage = null)



This method returns all Task connectors related to the run Process and Task.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class FindTaskConnectorsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | ID of Process to fetch
            var taskId = taskId_example;  // string | ID of Task to fetch
            var page = 56;  // int? | Page number to fetch (optional)  (default to 1)
            var perPage = 56;  // int? | Amount of items per Page (optional)  (default to 15)

            try
            {
                TaskConnectorsCollection result = apiInstance.FindTaskConnectors(processId, taskId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.FindTaskConnectors: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| ID of Process to fetch | 
 **taskId** | **string**| ID of Task to fetch | 
 **page** | **int?**| Page number to fetch | [optional] [default to 1]
 **perPage** | **int?**| Amount of items per Page | [optional] [default to 15]

### Return type

[**TaskConnectorsCollection**](TaskConnectorsCollection.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findtaskinstancebyid"></a>
# **FindTaskInstanceById**
> InlineResponse200 FindTaskInstanceById (string taskInstanceId, int? page = null, int? perPage = null)



This method retrieves a task instance based on its ID.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class FindTaskInstanceByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var taskInstanceId = taskInstanceId_example;  // string | ID of task instance to return
            var page = 56;  // int? | Page number to fetch (optional)  (default to 1)
            var perPage = 56;  // int? | Amount of items per page (optional)  (default to 15)

            try
            {
                InlineResponse200 result = apiInstance.FindTaskInstanceById(taskInstanceId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.FindTaskInstanceById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskInstanceId** | **string**| ID of task instance to return | 
 **page** | **int?**| Page number to fetch | [optional] [default to 1]
 **perPage** | **int?**| Amount of items per page | [optional] [default to 15]

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findtaskinstances"></a>
# **FindTaskInstances**
> TaskInstanceCollection FindTaskInstances (int? page = null, int? perPage = null)



This method retrieves all existing task instances

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class FindTaskInstancesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var page = 56;  // int? | Page number to fetch (optional)  (default to 1)
            var perPage = 56;  // int? | Amount of items per page (optional)  (default to 15)

            try
            {
                TaskInstanceCollection result = apiInstance.FindTaskInstances(page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.FindTaskInstances: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Page number to fetch | [optional] [default to 1]
 **perPage** | **int?**| Amount of items per page | [optional] [default to 15]

### Return type

[**TaskInstanceCollection**](TaskInstanceCollection.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findtasks"></a>
# **FindTasks**
> TaskCollection FindTasks (string processId, int? page = null, int? perPage = null)



This method is intended for returning a list of all Tasks related to the process

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class FindTasksExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | ID of Process relative to task
            var page = 56;  // int? | Page number to fetch (optional)  (default to 1)
            var perPage = 56;  // int? | Amount of items per Page (optional)  (default to 15)

            try
            {
                TaskCollection result = apiInstance.FindTasks(processId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.FindTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| ID of Process relative to task | 
 **page** | **int?**| Page number to fetch | [optional] [default to 1]
 **perPage** | **int?**| Amount of items per Page | [optional] [default to 15]

### Return type

[**TaskCollection**](TaskCollection.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="finduserbyid"></a>
# **FindUserById**
> UserItem FindUserById (string id)



This method returns a user using its ID.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class FindUserByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var id = id_example;  // string | ID of the user to return

            try
            {
                UserItem result = apiInstance.FindUserById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.FindUserById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the user to return | 

### Return type

[**UserItem**](UserItem.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findusers"></a>
# **FindUsers**
> UserCollection FindUsers (int? page = null, int? perPage = null)



This method returs all existing users in the system.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class FindUsersExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var page = 56;  // int? | Page number to fetch (optional)  (default to 1)
            var perPage = 56;  // int? | Amount of items per page (optional)  (default to 15)

            try
            {
                UserCollection result = apiInstance.FindUsers(page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.FindUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Page number to fetch | [optional] [default to 1]
 **perPage** | **int?**| Amount of items per page | [optional] [default to 15]

### Return type

[**UserCollection**](UserCollection.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importbpmnfile"></a>
# **ImportBpmnFile**
> ProcessCollection1 ImportBpmnFile (BpmnImportItem bpmnImportItem)



This method imports BPMN files. A new process is created when import is successful.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class ImportBpmnFileExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var bpmnImportItem = new BpmnImportItem(); // BpmnImportItem | JSON API with the BPMN file to import

            try
            {
                ProcessCollection1 result = apiInstance.ImportBpmnFile(bpmnImportItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.ImportBpmnFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bpmnImportItem** | [**BpmnImportItem**](BpmnImportItem.md)| JSON API with the BPMN file to import | 

### Return type

[**ProcessCollection1**](ProcessCollection1.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="myselfuser"></a>
# **MyselfUser**
> UserItem MyselfUser (int? page = null, int? perPage = null)



This method returns user information using a token

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class MyselfUserExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var page = 56;  // int? | Page number to fetch (optional)  (default to 1)
            var perPage = 56;  // int? | Amount of items per page (optional)  (default to 15)

            try
            {
                UserItem result = apiInstance.MyselfUser(page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.MyselfUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Page number to fetch | [optional] [default to 1]
 **perPage** | **int?**| Amount of items per page | [optional] [default to 15]

### Return type

[**UserItem**](UserItem.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removegroupsfromtask"></a>
# **RemoveGroupsFromTask**
> ResultSuccess RemoveGroupsFromTask (string processId, string taskId, TaskRemoveGroupsItem taskRemoveGroupsItem)



This method removes groups from a task

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class RemoveGroupsFromTaskExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | Process ID
            var taskId = taskId_example;  // string | Task ID
            var taskRemoveGroupsItem = new TaskRemoveGroupsItem(); // TaskRemoveGroupsItem | JSON API response with Groups IDs to remove

            try
            {
                ResultSuccess result = apiInstance.RemoveGroupsFromTask(processId, taskId, taskRemoveGroupsItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.RemoveGroupsFromTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| Process ID | 
 **taskId** | **string**| Task ID | 
 **taskRemoveGroupsItem** | [**TaskRemoveGroupsItem**](TaskRemoveGroupsItem.md)| JSON API response with Groups IDs to remove | 

### Return type

[**ResultSuccess**](ResultSuccess.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeusersfromgroup"></a>
# **RemoveUsersFromGroup**
> ResultSuccess RemoveUsersFromGroup (string id, GroupRemoveUsersItem groupRemoveUsersItem)



This method removes one or more users from a group.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class RemoveUsersFromGroupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var id = id_example;  // string | ID of group to be modified
            var groupRemoveUsersItem = new GroupRemoveUsersItem(); // GroupRemoveUsersItem | JSON API response with Users IDs to remove

            try
            {
                ResultSuccess result = apiInstance.RemoveUsersFromGroup(id, groupRemoveUsersItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.RemoveUsersFromGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of group to be modified | 
 **groupRemoveUsersItem** | [**GroupRemoveUsersItem**](GroupRemoveUsersItem.md)| JSON API response with Users IDs to remove | 

### Return type

[**ResultSuccess**](ResultSuccess.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="syncgroupstotask"></a>
# **SyncGroupsToTask**
> ResultSuccess SyncGroupsToTask (string processId, string taskId, TaskSyncGroupsItem taskSyncGroupsItem)



This method synchronizes a one or more groups with a task.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class SyncGroupsToTaskExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | Process ID
            var taskId = taskId_example;  // string | ID of task to modify
            var taskSyncGroupsItem = new TaskSyncGroupsItem(); // TaskSyncGroupsItem | JSON API response with groups IDs to sync

            try
            {
                ResultSuccess result = apiInstance.SyncGroupsToTask(processId, taskId, taskSyncGroupsItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.SyncGroupsToTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| Process ID | 
 **taskId** | **string**| ID of task to modify | 
 **taskSyncGroupsItem** | [**TaskSyncGroupsItem**](TaskSyncGroupsItem.md)| JSON API response with groups IDs to sync | 

### Return type

[**ResultSuccess**](ResultSuccess.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="syncuserstogroup"></a>
# **SyncUsersToGroup**
> ResultSuccess SyncUsersToGroup (string id, GroupSyncUsersItem groupSyncUsersItem)



This method synchronizes one or more users with a group.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class SyncUsersToGroupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var id = id_example;  // string | ID of group to be modifieded
            var groupSyncUsersItem = new GroupSyncUsersItem(); // GroupSyncUsersItem | JSON API with array of users IDs to sync

            try
            {
                ResultSuccess result = apiInstance.SyncUsersToGroup(id, groupSyncUsersItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.SyncUsersToGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of group to be modifieded | 
 **groupSyncUsersItem** | [**GroupSyncUsersItem**](GroupSyncUsersItem.md)| JSON API with array of users IDs to sync | 

### Return type

[**ResultSuccess**](ResultSuccess.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateclient"></a>
# **UpdateClient**
> ClientItem UpdateClient (string userId, string clientId, ClientUpdateItem clientUpdateItem)



This method updates an existing Oauth client.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class UpdateClientExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var userId = userId_example;  // string | ID of user to retrieve
            var clientId = clientId_example;  // string | ID of client to retrieve
            var clientUpdateItem = new ClientUpdateItem(); // ClientUpdateItem | Client object to edit

            try
            {
                ClientItem result = apiInstance.UpdateClient(userId, clientId, clientUpdateItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.UpdateClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| ID of user to retrieve | 
 **clientId** | **string**| ID of client to retrieve | 
 **clientUpdateItem** | [**ClientUpdateItem**](ClientUpdateItem.md)| Client object to edit | 

### Return type

[**ClientItem**](ClientItem.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateevent"></a>
# **UpdateEvent**
> EventItem UpdateEvent (string processId, string eventId, EventUpdateItem eventUpdateItem)



This method updates an existing event

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class UpdateEventExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | ID of process to retrieve
            var eventId = eventId_example;  // string | ID of event to retrieve
            var eventUpdateItem = new EventUpdateItem(); // EventUpdateItem | Event object to edit

            try
            {
                EventItem result = apiInstance.UpdateEvent(processId, eventId, eventUpdateItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.UpdateEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| ID of process to retrieve | 
 **eventId** | **string**| ID of event to retrieve | 
 **eventUpdateItem** | [**EventUpdateItem**](EventUpdateItem.md)| Event object to edit | 

### Return type

[**EventItem**](EventItem.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateeventconnector"></a>
# **UpdateEventConnector**
> EventConnector1 UpdateEventConnector (string processId, string eventId, string connectorId, EventConnectorUpdateItem eventConnectorUpdateItem)



This method lets update the existing Event connector with new parameters values

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class UpdateEventConnectorExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | ID of Process to fetch
            var eventId = eventId_example;  // string | ID of Event to fetch
            var connectorId = connectorId_example;  // string | ID of Event Connector to fetch
            var eventConnectorUpdateItem = new EventConnectorUpdateItem(); // EventConnectorUpdateItem | EventConnector object to edit

            try
            {
                EventConnector1 result = apiInstance.UpdateEventConnector(processId, eventId, connectorId, eventConnectorUpdateItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.UpdateEventConnector: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| ID of Process to fetch | 
 **eventId** | **string**| ID of Event to fetch | 
 **connectorId** | **string**| ID of Event Connector to fetch | 
 **eventConnectorUpdateItem** | [**EventConnectorUpdateItem**](EventConnectorUpdateItem.md)| EventConnector object to edit | 

### Return type

[**EventConnector1**](EventConnector1.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateflow"></a>
# **UpdateFlow**
> FlowItem UpdateFlow (string processId, string flowId, FlowUpdateItem flowUpdateItem)



This method updates an existing flow.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class UpdateFlowExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | ID of process to retrieve
            var flowId = flowId_example;  // string | ID of flow to retrieve
            var flowUpdateItem = new FlowUpdateItem(); // FlowUpdateItem | Flow object to edit

            try
            {
                FlowItem result = apiInstance.UpdateFlow(processId, flowId, flowUpdateItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.UpdateFlow: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| ID of process to retrieve | 
 **flowId** | **string**| ID of flow to retrieve | 
 **flowUpdateItem** | [**FlowUpdateItem**](FlowUpdateItem.md)| Flow object to edit | 

### Return type

[**FlowItem**](FlowItem.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategateway"></a>
# **UpdateGateway**
> GatewayItem UpdateGateway (string processId, string gatewayId, GatewayUpdateItem gatewayUpdateItem)



This method updates an existing gateway.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class UpdateGatewayExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | ID of process to retrieve
            var gatewayId = gatewayId_example;  // string | ID of gateway to retrieve
            var gatewayUpdateItem = new GatewayUpdateItem(); // GatewayUpdateItem | Gateway object to edit

            try
            {
                GatewayItem result = apiInstance.UpdateGateway(processId, gatewayId, gatewayUpdateItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.UpdateGateway: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| ID of process to retrieve | 
 **gatewayId** | **string**| ID of gateway to retrieve | 
 **gatewayUpdateItem** | [**GatewayUpdateItem**](GatewayUpdateItem.md)| Gateway object to edit | 

### Return type

[**GatewayItem**](GatewayItem.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategroup"></a>
# **UpdateGroup**
> GroupItem UpdateGroup (string id, GroupUpdateItem groupUpdateItem)



This method updates an existing group.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class UpdateGroupExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var id = id_example;  // string | ID of group to retrieve
            var groupUpdateItem = new GroupUpdateItem(); // GroupUpdateItem | Group object to edit

            try
            {
                GroupItem result = apiInstance.UpdateGroup(id, groupUpdateItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.UpdateGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of group to retrieve | 
 **groupUpdateItem** | [**GroupUpdateItem**](GroupUpdateItem.md)| Group object to edit | 

### Return type

[**GroupItem**](GroupItem.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateinputoutput"></a>
# **UpdateInputOutput**
> InputOutputItem UpdateInputOutput (string processId, string taskId, string inputoutputUid, InputOutputUpdateItem inputOutputUpdateItem)



This method updates an existing Input/Output object.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class UpdateInputOutputExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | Process ID related to the Input/Output object
            var taskId = taskId_example;  // string | Task instance ID related to the Input/Output object
            var inputoutputUid = inputoutputUid_example;  // string | ID of Input/Output to retrieve
            var inputOutputUpdateItem = new InputOutputUpdateItem(); // InputOutputUpdateItem | Input/Output object to edit

            try
            {
                InputOutputItem result = apiInstance.UpdateInputOutput(processId, taskId, inputoutputUid, inputOutputUpdateItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.UpdateInputOutput: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| Process ID related to the Input/Output object | 
 **taskId** | **string**| Task instance ID related to the Input/Output object | 
 **inputoutputUid** | **string**| ID of Input/Output to retrieve | 
 **inputOutputUpdateItem** | [**InputOutputUpdateItem**](InputOutputUpdateItem.md)| Input/Output object to edit | 

### Return type

[**InputOutputItem**](InputOutputItem.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateinstance"></a>
# **UpdateInstance**
> InstanceItem UpdateInstance (string processId, string instanceId, InstanceUpdateItem instanceUpdateItem)



This method updates  an existing instance.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class UpdateInstanceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | ID of Process to retrieve
            var instanceId = instanceId_example;  // string | ID of Instance to retrieve
            var instanceUpdateItem = new InstanceUpdateItem(); // InstanceUpdateItem | Instance object to edit

            try
            {
                InstanceItem result = apiInstance.UpdateInstance(processId, instanceId, instanceUpdateItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.UpdateInstance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| ID of Process to retrieve | 
 **instanceId** | **string**| ID of Instance to retrieve | 
 **instanceUpdateItem** | [**InstanceUpdateItem**](InstanceUpdateItem.md)| Instance object to edit | 

### Return type

[**InstanceItem**](InstanceItem.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprocess"></a>
# **UpdateProcess**
> ProcessItem UpdateProcess (string id, ProcessUpdateItem processUpdateItem)



This method updates an existing process.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class UpdateProcessExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var id = id_example;  // string | ID of process to retrieve
            var processUpdateItem = new ProcessUpdateItem(); // ProcessUpdateItem | Process object to edit

            try
            {
                ProcessItem result = apiInstance.UpdateProcess(id, processUpdateItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.UpdateProcess: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of process to retrieve | 
 **processUpdateItem** | [**ProcessUpdateItem**](ProcessUpdateItem.md)| Process object to edit | 

### Return type

[**ProcessItem**](ProcessItem.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetask"></a>
# **UpdateTask**
> TaskItem UpdateTask (string processId, string taskId, TaskUpdateItem taskUpdateItem)



This method is intended for updating an existing task.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class UpdateTaskExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | ID of Process to fetch
            var taskId = taskId_example;  // string | ID of Task to fetch
            var taskUpdateItem = new TaskUpdateItem(); // TaskUpdateItem | Task object to edit

            try
            {
                TaskItem result = apiInstance.UpdateTask(processId, taskId, taskUpdateItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.UpdateTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| ID of Process to fetch | 
 **taskId** | **string**| ID of Task to fetch | 
 **taskUpdateItem** | [**TaskUpdateItem**](TaskUpdateItem.md)| Task object to edit | 

### Return type

[**TaskItem**](TaskItem.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetaskconnector"></a>
# **UpdateTaskConnector**
> TaskConnector1 UpdateTaskConnector (string processId, string taskId, string connectorId, TaskConnectorUpdateItem taskConnectorUpdateItem)



This method lets update the existing Task connector with new parameters values

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class UpdateTaskConnectorExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var processId = processId_example;  // string | ID of Process to fetch
            var taskId = taskId_example;  // string | ID of Task to fetch
            var connectorId = connectorId_example;  // string | ID of Task Connector to fetch
            var taskConnectorUpdateItem = new TaskConnectorUpdateItem(); // TaskConnectorUpdateItem | TaskConnector object to edit

            try
            {
                TaskConnector1 result = apiInstance.UpdateTaskConnector(processId, taskId, connectorId, taskConnectorUpdateItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.UpdateTaskConnector: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **processId** | **string**| ID of Process to fetch | 
 **taskId** | **string**| ID of Task to fetch | 
 **connectorId** | **string**| ID of Task Connector to fetch | 
 **taskConnectorUpdateItem** | [**TaskConnectorUpdateItem**](TaskConnectorUpdateItem.md)| TaskConnector object to edit | 

### Return type

[**TaskConnector1**](TaskConnector1.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetaskinstance"></a>
# **UpdateTaskInstance**
> InlineResponse200 UpdateTaskInstance (string taskInstanceId, TaskInstanceUpdateItem taskInstanceUpdateItem)



This method updates an existing task instance.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class UpdateTaskInstanceExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var taskInstanceId = taskInstanceId_example;  // string | ID of task instance to retrieve
            var taskInstanceUpdateItem = new TaskInstanceUpdateItem(); // TaskInstanceUpdateItem | Task Instance object to update

            try
            {
                InlineResponse200 result = apiInstance.UpdateTaskInstance(taskInstanceId, taskInstanceUpdateItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.UpdateTaskInstance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskInstanceId** | **string**| ID of task instance to retrieve | 
 **taskInstanceUpdateItem** | [**TaskInstanceUpdateItem**](TaskInstanceUpdateItem.md)| Task Instance object to update | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuser"></a>
# **UpdateUser**
> UserItem UpdateUser (string id, UserUpdateItem userUpdateItem)



This method updates an existing user.

### Example
```csharp
using System;
using System.Diagnostics;
using ProcessMaker.PMIO.Api;
using ProcessMaker.PMIO.Client;
using ProcessMaker.PMIO.Model;

namespace Example
{
    public class UpdateUserExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: PasswordGrant
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProcessmakerApi();
            var id = id_example;  // string | ID of user to retrieve
            var userUpdateItem = new UserUpdateItem(); // UserUpdateItem | User object for update

            try
            {
                UserItem result = apiInstance.UpdateUser(id, userUpdateItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProcessmakerApi.UpdateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of user to retrieve | 
 **userUpdateItem** | [**UserUpdateItem**](UserUpdateItem.md)| User object for update | 

### Return type

[**UserItem**](UserItem.md)

### Authorization

[PasswordGrant](../README.md#PasswordGrant)

### HTTP request headers

 - **Content-Type**: application/vnd.api+json
 - **Accept**: application/vnd.api+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

