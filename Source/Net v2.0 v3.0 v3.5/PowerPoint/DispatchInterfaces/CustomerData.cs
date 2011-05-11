//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface CustomerData SupportByLibrary PP12 PP14 
	///</summary>
	[SupportByLibrary("PP12","PP14")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class CustomerData : Collection
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomerData(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomerData(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomerData(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomerData()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP12","PP14")]
		public NetOffice.PowerPointApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.PowerPointApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP12","PP14")]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		/// <param name="Id">string Id</param>
		[SupportByLibrary("PP12","PP14")]
		public NetOffice.OfficeApi.CustomXMLPart Item(string id)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(id);
			object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
			NetOffice.OfficeApi.CustomXMLPart newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OfficeApi.CustomXMLPart;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP12","PP14")]
		public NetOffice.OfficeApi.CustomXMLPart Add()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.CustomXMLPart newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OfficeApi.CustomXMLPart;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		/// <param name="Id">string Id</param>
		[SupportByLibrary("PP12","PP14")]
		public void Delete(string id)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(id);
			Invoker.Method(this, "Delete", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}