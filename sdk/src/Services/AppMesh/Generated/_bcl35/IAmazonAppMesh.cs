/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the appmesh-2018-10-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.AppMesh.Model;

namespace Amazon.AppMesh
{
    /// <summary>
    /// Interface for accessing AppMesh
    ///
    /// AWS App Mesh is a service mesh based on the Envoy proxy that makes it easy to monitor
    /// and         control containerized microservices. App Mesh standardizes how your microservices
    ///         communicate, giving you end-to-end visibility and helping to ensure high-availability
    /// for         your applications.
    /// 
    ///          
    /// <para>
    /// App Mesh gives you consistent visibility and network traffic controls for every  
    ///       microservice in an application. You can use App Mesh with Amazon ECS       
    ///  (using the Amazon EC2 launch type), Amazon EKS, and Kubernetes on AWS.
    /// </para>
    ///          <note>            
    /// <para>
    /// App Mesh supports containerized microservice applications that use service discovery
    ///            naming for their components. To use App Mesh, you must have a containerized
    /// application            running on Amazon EC2 instances, hosted in either Amazon ECS,
    /// Amazon EKS, or Kubernetes on AWS. For            more information about service discovery
    /// on Amazon ECS, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguideservice-discovery.html">Service
    /// Discovery</a> in the               <i>Amazon Elastic Container Service Developer Guide</i>.
    /// Kubernetes <code>kube-dns</code> is supported.            For more information, see
    /// <a href="https://kubernetes.io/docs/concepts/services-networking/dns-pod-service/">DNS
    ///               for Services and Pods</a> in the Kubernetes documentation.
    /// </para>
    ///          </note>
    /// </summary>
    public partial interface IAmazonAppMesh : IAmazonService, IDisposable
    {

        
        #region  CreateMesh


        /// <summary>
        /// Creates a new service mesh. A service mesh is a logical boundary for network traffic
        ///         between the services that reside within it.
        /// 
        ///          
        /// <para>
        /// After you create your service mesh, you can create virtual nodes, virtual routers,
        /// and         routes to distribute traffic between the applications in your mesh.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMesh service method.</param>
        /// 
        /// <returns>The response from the CreateMesh service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ConflictException">
        /// The request contains a client token that was used for a previous update resource call
        ///         with different specifications. Try the request again with a new client token.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.LimitExceededException">
        /// You have exceeded a service limit for your account. For more information, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/service_limits.html">Service
        /// Limits</a> in the <i>AWS App Mesh User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/CreateMesh">REST API Reference for CreateMesh Operation</seealso>
        CreateMeshResponse CreateMesh(CreateMeshRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMesh operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMesh operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMesh
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/CreateMesh">REST API Reference for CreateMesh Operation</seealso>
        IAsyncResult BeginCreateMesh(CreateMeshRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMesh operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMesh.</param>
        /// 
        /// <returns>Returns a  CreateMeshResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/CreateMesh">REST API Reference for CreateMesh Operation</seealso>
        CreateMeshResponse EndCreateMesh(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRoute


        /// <summary>
        /// Creates a new route that is associated with a virtual router.
        /// 
        ///          
        /// <para>
        /// You can use the <code>prefix</code> parameter in your route specification for path-based
        ///         routing of requests. For example, if your virtual router service name is 
        ///           <code>my-service.local</code>, and you want the route to match requests
        /// to            <code>my-service.local/metrics</code>, then your prefix should be  
        ///       <code>/metrics</code>.
        /// </para>
        ///          
        /// <para>
        /// If your route matches a request, you can distribute traffic to one or more target
        ///         virtual nodes with relative weighting.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoute service method.</param>
        /// 
        /// <returns>The response from the CreateRoute service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ConflictException">
        /// The request contains a client token that was used for a previous update resource call
        ///         with different specifications. Try the request again with a new client token.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.LimitExceededException">
        /// You have exceeded a service limit for your account. For more information, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/service_limits.html">Service
        /// Limits</a> in the <i>AWS App Mesh User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/CreateRoute">REST API Reference for CreateRoute Operation</seealso>
        CreateRouteResponse CreateRoute(CreateRouteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRoute operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRoute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/CreateRoute">REST API Reference for CreateRoute Operation</seealso>
        IAsyncResult BeginCreateRoute(CreateRouteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRoute.</param>
        /// 
        /// <returns>Returns a  CreateRouteResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/CreateRoute">REST API Reference for CreateRoute Operation</seealso>
        CreateRouteResponse EndCreateRoute(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVirtualNode


        /// <summary>
        /// Creates a new virtual node within a service mesh.
        /// 
        ///          
        /// <para>
        /// A virtual node acts as logical pointer to a particular task group, such as an Amazon
        /// ECS         service or a Kubernetes deployment. When you create a virtual node, you
        /// must specify the         DNS service discovery name for your task group.
        /// </para>
        ///          
        /// <para>
        /// Any inbound traffic that your virtual node expects should be specified as a      
        ///      <code>listener</code>. Any outbound traffic that your virtual node expects to
        /// reach         should be specified as a <code>backend</code>.
        /// </para>
        ///          
        /// <para>
        /// The response metadata for your new virtual node contains the <code>arn</code> that
        /// is         associated with the virtual node. Set this value (either the full ARN or
        /// the truncated         resource name, for example, <code>mesh/default/virtualNode/simpleapp</code>,
        /// as the            <code>APPMESH_VIRTUAL_NODE_NAME</code> environment variable for
        /// your task group's Envoy         proxy container in your task definition or pod spec.
        /// This is then mapped to the            <code>node.id</code> and <code>node.cluster</code>
        /// Envoy parameters.
        /// </para>
        ///          <note>            
        /// <para>
        /// If you require your Envoy stats or tracing to use a different name, you can override
        ///            the <code>node.cluster</code> value that is set by               <code>APPMESH_VIRTUAL_NODE_NAME</code>
        /// with the               <code>APPMESH_VIRTUAL_NODE_CLUSTER</code> environment variable.
        /// </para>
        ///          </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualNode service method.</param>
        /// 
        /// <returns>The response from the CreateVirtualNode service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ConflictException">
        /// The request contains a client token that was used for a previous update resource call
        ///         with different specifications. Try the request again with a new client token.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.LimitExceededException">
        /// You have exceeded a service limit for your account. For more information, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/service_limits.html">Service
        /// Limits</a> in the <i>AWS App Mesh User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/CreateVirtualNode">REST API Reference for CreateVirtualNode Operation</seealso>
        CreateVirtualNodeResponse CreateVirtualNode(CreateVirtualNodeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVirtualNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualNode operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVirtualNode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/CreateVirtualNode">REST API Reference for CreateVirtualNode Operation</seealso>
        IAsyncResult BeginCreateVirtualNode(CreateVirtualNodeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVirtualNode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVirtualNode.</param>
        /// 
        /// <returns>Returns a  CreateVirtualNodeResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/CreateVirtualNode">REST API Reference for CreateVirtualNode Operation</seealso>
        CreateVirtualNodeResponse EndCreateVirtualNode(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVirtualRouter


        /// <summary>
        /// Creates a new virtual router within a service mesh.
        /// 
        ///          
        /// <para>
        /// Virtual routers handle traffic for one or more service names within your mesh. After
        /// you         create your virtual router, create and associate routes for your virtual
        /// router that direct         incoming requests to different virtual nodes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualRouter service method.</param>
        /// 
        /// <returns>The response from the CreateVirtualRouter service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ConflictException">
        /// The request contains a client token that was used for a previous update resource call
        ///         with different specifications. Try the request again with a new client token.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.LimitExceededException">
        /// You have exceeded a service limit for your account. For more information, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/service_limits.html">Service
        /// Limits</a> in the <i>AWS App Mesh User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/CreateVirtualRouter">REST API Reference for CreateVirtualRouter Operation</seealso>
        CreateVirtualRouterResponse CreateVirtualRouter(CreateVirtualRouterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVirtualRouter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualRouter operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVirtualRouter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/CreateVirtualRouter">REST API Reference for CreateVirtualRouter Operation</seealso>
        IAsyncResult BeginCreateVirtualRouter(CreateVirtualRouterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVirtualRouter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVirtualRouter.</param>
        /// 
        /// <returns>Returns a  CreateVirtualRouterResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/CreateVirtualRouter">REST API Reference for CreateVirtualRouter Operation</seealso>
        CreateVirtualRouterResponse EndCreateVirtualRouter(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMesh


        /// <summary>
        /// Deletes an existing service mesh.
        /// 
        ///          
        /// <para>
        /// You must delete all resources (routes, virtual routers, virtual nodes) in the service
        ///         mesh before you can delete the mesh itself.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMesh service method.</param>
        /// 
        /// <returns>The response from the DeleteMesh service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ResourceInUseException">
        /// You cannot delete the specified resource because it is in use or required by another
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DeleteMesh">REST API Reference for DeleteMesh Operation</seealso>
        DeleteMeshResponse DeleteMesh(DeleteMeshRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMesh operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMesh operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMesh
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DeleteMesh">REST API Reference for DeleteMesh Operation</seealso>
        IAsyncResult BeginDeleteMesh(DeleteMeshRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMesh operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMesh.</param>
        /// 
        /// <returns>Returns a  DeleteMeshResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DeleteMesh">REST API Reference for DeleteMesh Operation</seealso>
        DeleteMeshResponse EndDeleteMesh(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRoute


        /// <summary>
        /// Deletes an existing route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute service method.</param>
        /// 
        /// <returns>The response from the DeleteRoute service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ResourceInUseException">
        /// You cannot delete the specified resource because it is in use or required by another
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DeleteRoute">REST API Reference for DeleteRoute Operation</seealso>
        DeleteRouteResponse DeleteRoute(DeleteRouteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRoute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DeleteRoute">REST API Reference for DeleteRoute Operation</seealso>
        IAsyncResult BeginDeleteRoute(DeleteRouteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRoute.</param>
        /// 
        /// <returns>Returns a  DeleteRouteResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DeleteRoute">REST API Reference for DeleteRoute Operation</seealso>
        DeleteRouteResponse EndDeleteRoute(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVirtualNode


        /// <summary>
        /// Deletes an existing virtual node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualNode service method.</param>
        /// 
        /// <returns>The response from the DeleteVirtualNode service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ResourceInUseException">
        /// You cannot delete the specified resource because it is in use or required by another
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DeleteVirtualNode">REST API Reference for DeleteVirtualNode Operation</seealso>
        DeleteVirtualNodeResponse DeleteVirtualNode(DeleteVirtualNodeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVirtualNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualNode operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVirtualNode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DeleteVirtualNode">REST API Reference for DeleteVirtualNode Operation</seealso>
        IAsyncResult BeginDeleteVirtualNode(DeleteVirtualNodeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVirtualNode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVirtualNode.</param>
        /// 
        /// <returns>Returns a  DeleteVirtualNodeResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DeleteVirtualNode">REST API Reference for DeleteVirtualNode Operation</seealso>
        DeleteVirtualNodeResponse EndDeleteVirtualNode(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVirtualRouter


        /// <summary>
        /// Deletes an existing virtual router.
        /// 
        ///          
        /// <para>
        /// You must delete any routes associated with the virtual router before you can delete
        /// the         router itself.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualRouter service method.</param>
        /// 
        /// <returns>The response from the DeleteVirtualRouter service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ResourceInUseException">
        /// You cannot delete the specified resource because it is in use or required by another
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DeleteVirtualRouter">REST API Reference for DeleteVirtualRouter Operation</seealso>
        DeleteVirtualRouterResponse DeleteVirtualRouter(DeleteVirtualRouterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVirtualRouter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualRouter operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVirtualRouter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DeleteVirtualRouter">REST API Reference for DeleteVirtualRouter Operation</seealso>
        IAsyncResult BeginDeleteVirtualRouter(DeleteVirtualRouterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVirtualRouter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVirtualRouter.</param>
        /// 
        /// <returns>Returns a  DeleteVirtualRouterResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DeleteVirtualRouter">REST API Reference for DeleteVirtualRouter Operation</seealso>
        DeleteVirtualRouterResponse EndDeleteVirtualRouter(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeMesh


        /// <summary>
        /// Describes an existing cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMesh service method.</param>
        /// 
        /// <returns>The response from the DescribeMesh service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DescribeMesh">REST API Reference for DescribeMesh Operation</seealso>
        DescribeMeshResponse DescribeMesh(DescribeMeshRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMesh operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMesh operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMesh
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DescribeMesh">REST API Reference for DescribeMesh Operation</seealso>
        IAsyncResult BeginDescribeMesh(DescribeMeshRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMesh operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMesh.</param>
        /// 
        /// <returns>Returns a  DescribeMeshResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DescribeMesh">REST API Reference for DescribeMesh Operation</seealso>
        DescribeMeshResponse EndDescribeMesh(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeRoute


        /// <summary>
        /// Describes an existing route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRoute service method.</param>
        /// 
        /// <returns>The response from the DescribeRoute service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DescribeRoute">REST API Reference for DescribeRoute Operation</seealso>
        DescribeRouteResponse DescribeRoute(DescribeRouteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRoute operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRoute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DescribeRoute">REST API Reference for DescribeRoute Operation</seealso>
        IAsyncResult BeginDescribeRoute(DescribeRouteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRoute.</param>
        /// 
        /// <returns>Returns a  DescribeRouteResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DescribeRoute">REST API Reference for DescribeRoute Operation</seealso>
        DescribeRouteResponse EndDescribeRoute(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVirtualNode


        /// <summary>
        /// Describes an existing virtual node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualNode service method.</param>
        /// 
        /// <returns>The response from the DescribeVirtualNode service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DescribeVirtualNode">REST API Reference for DescribeVirtualNode Operation</seealso>
        DescribeVirtualNodeResponse DescribeVirtualNode(DescribeVirtualNodeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVirtualNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualNode operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVirtualNode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DescribeVirtualNode">REST API Reference for DescribeVirtualNode Operation</seealso>
        IAsyncResult BeginDescribeVirtualNode(DescribeVirtualNodeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVirtualNode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVirtualNode.</param>
        /// 
        /// <returns>Returns a  DescribeVirtualNodeResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DescribeVirtualNode">REST API Reference for DescribeVirtualNode Operation</seealso>
        DescribeVirtualNodeResponse EndDescribeVirtualNode(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVirtualRouter


        /// <summary>
        /// Describes an existing virtual router.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualRouter service method.</param>
        /// 
        /// <returns>The response from the DescribeVirtualRouter service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DescribeVirtualRouter">REST API Reference for DescribeVirtualRouter Operation</seealso>
        DescribeVirtualRouterResponse DescribeVirtualRouter(DescribeVirtualRouterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVirtualRouter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualRouter operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVirtualRouter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DescribeVirtualRouter">REST API Reference for DescribeVirtualRouter Operation</seealso>
        IAsyncResult BeginDescribeVirtualRouter(DescribeVirtualRouterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVirtualRouter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVirtualRouter.</param>
        /// 
        /// <returns>Returns a  DescribeVirtualRouterResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DescribeVirtualRouter">REST API Reference for DescribeVirtualRouter Operation</seealso>
        DescribeVirtualRouterResponse EndDescribeVirtualRouter(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMeshes


        /// <summary>
        /// Returns a list of existing service meshes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMeshes service method.</param>
        /// 
        /// <returns>The response from the ListMeshes service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/ListMeshes">REST API Reference for ListMeshes Operation</seealso>
        ListMeshesResponse ListMeshes(ListMeshesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMeshes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMeshes operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMeshes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/ListMeshes">REST API Reference for ListMeshes Operation</seealso>
        IAsyncResult BeginListMeshes(ListMeshesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMeshes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMeshes.</param>
        /// 
        /// <returns>Returns a  ListMeshesResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/ListMeshes">REST API Reference for ListMeshes Operation</seealso>
        ListMeshesResponse EndListMeshes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRoutes


        /// <summary>
        /// Returns a list of existing routes in a service mesh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoutes service method.</param>
        /// 
        /// <returns>The response from the ListRoutes service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/ListRoutes">REST API Reference for ListRoutes Operation</seealso>
        ListRoutesResponse ListRoutes(ListRoutesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRoutes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRoutes operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRoutes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/ListRoutes">REST API Reference for ListRoutes Operation</seealso>
        IAsyncResult BeginListRoutes(ListRoutesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRoutes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRoutes.</param>
        /// 
        /// <returns>Returns a  ListRoutesResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/ListRoutes">REST API Reference for ListRoutes Operation</seealso>
        ListRoutesResponse EndListRoutes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVirtualNodes


        /// <summary>
        /// Returns a list of existing virtual nodes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualNodes service method.</param>
        /// 
        /// <returns>The response from the ListVirtualNodes service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/ListVirtualNodes">REST API Reference for ListVirtualNodes Operation</seealso>
        ListVirtualNodesResponse ListVirtualNodes(ListVirtualNodesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVirtualNodes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualNodes operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVirtualNodes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/ListVirtualNodes">REST API Reference for ListVirtualNodes Operation</seealso>
        IAsyncResult BeginListVirtualNodes(ListVirtualNodesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVirtualNodes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVirtualNodes.</param>
        /// 
        /// <returns>Returns a  ListVirtualNodesResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/ListVirtualNodes">REST API Reference for ListVirtualNodes Operation</seealso>
        ListVirtualNodesResponse EndListVirtualNodes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVirtualRouters


        /// <summary>
        /// Returns a list of existing virtual routers in a service mesh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualRouters service method.</param>
        /// 
        /// <returns>The response from the ListVirtualRouters service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/ListVirtualRouters">REST API Reference for ListVirtualRouters Operation</seealso>
        ListVirtualRoutersResponse ListVirtualRouters(ListVirtualRoutersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVirtualRouters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualRouters operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVirtualRouters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/ListVirtualRouters">REST API Reference for ListVirtualRouters Operation</seealso>
        IAsyncResult BeginListVirtualRouters(ListVirtualRoutersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVirtualRouters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVirtualRouters.</param>
        /// 
        /// <returns>Returns a  ListVirtualRoutersResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/ListVirtualRouters">REST API Reference for ListVirtualRouters Operation</seealso>
        ListVirtualRoutersResponse EndListVirtualRouters(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRoute


        /// <summary>
        /// Updates an existing route for a specified service mesh and virtual router.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoute service method.</param>
        /// 
        /// <returns>The response from the UpdateRoute service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ConflictException">
        /// The request contains a client token that was used for a previous update resource call
        ///         with different specifications. Try the request again with a new client token.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.LimitExceededException">
        /// You have exceeded a service limit for your account. For more information, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/service_limits.html">Service
        /// Limits</a> in the <i>AWS App Mesh User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/UpdateRoute">REST API Reference for UpdateRoute Operation</seealso>
        UpdateRouteResponse UpdateRoute(UpdateRouteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoute operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRoute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/UpdateRoute">REST API Reference for UpdateRoute Operation</seealso>
        IAsyncResult BeginUpdateRoute(UpdateRouteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRoute.</param>
        /// 
        /// <returns>Returns a  UpdateRouteResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/UpdateRoute">REST API Reference for UpdateRoute Operation</seealso>
        UpdateRouteResponse EndUpdateRoute(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateVirtualNode


        /// <summary>
        /// Updates an existing virtual node in a specified service mesh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVirtualNode service method.</param>
        /// 
        /// <returns>The response from the UpdateVirtualNode service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ConflictException">
        /// The request contains a client token that was used for a previous update resource call
        ///         with different specifications. Try the request again with a new client token.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.LimitExceededException">
        /// You have exceeded a service limit for your account. For more information, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/service_limits.html">Service
        /// Limits</a> in the <i>AWS App Mesh User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/UpdateVirtualNode">REST API Reference for UpdateVirtualNode Operation</seealso>
        UpdateVirtualNodeResponse UpdateVirtualNode(UpdateVirtualNodeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVirtualNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVirtualNode operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVirtualNode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/UpdateVirtualNode">REST API Reference for UpdateVirtualNode Operation</seealso>
        IAsyncResult BeginUpdateVirtualNode(UpdateVirtualNodeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVirtualNode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVirtualNode.</param>
        /// 
        /// <returns>Returns a  UpdateVirtualNodeResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/UpdateVirtualNode">REST API Reference for UpdateVirtualNode Operation</seealso>
        UpdateVirtualNodeResponse EndUpdateVirtualNode(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateVirtualRouter


        /// <summary>
        /// Updates an existing virtual router in a specified service mesh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVirtualRouter service method.</param>
        /// 
        /// <returns>The response from the UpdateVirtualRouter service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ConflictException">
        /// The request contains a client token that was used for a previous update resource call
        ///         with different specifications. Try the request again with a new client token.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.LimitExceededException">
        /// You have exceeded a service limit for your account. For more information, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/service_limits.html">Service
        /// Limits</a> in the <i>AWS App Mesh User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/UpdateVirtualRouter">REST API Reference for UpdateVirtualRouter Operation</seealso>
        UpdateVirtualRouterResponse UpdateVirtualRouter(UpdateVirtualRouterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVirtualRouter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVirtualRouter operation on AmazonAppMeshClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVirtualRouter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/UpdateVirtualRouter">REST API Reference for UpdateVirtualRouter Operation</seealso>
        IAsyncResult BeginUpdateVirtualRouter(UpdateVirtualRouterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVirtualRouter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVirtualRouter.</param>
        /// 
        /// <returns>Returns a  UpdateVirtualRouterResult from AppMesh.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/UpdateVirtualRouter">REST API Reference for UpdateVirtualRouter Operation</seealso>
        UpdateVirtualRouterResponse EndUpdateVirtualRouter(IAsyncResult asyncResult);

        #endregion
        
    }
}