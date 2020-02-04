// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

// ReSharper disable once CheckNamespace
namespace Elasticsearch.Net.Specification.DataFrameApi
{
	///<summary>Request options for DeleteTransform <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/delete-transform.html</para></summary>
	public class DeleteDataFrameTransformRequestParameters : RequestParameters<DeleteDataFrameTransformRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
		///<summary>
		/// When `true`, the transform is deleted regardless of its current state. The default value is `false`, meaning that the transform must be
		/// `stopped` before it can be deleted.
		///</summary>
		public bool? Force
		{
			get => Q<bool? >("force");
			set => Q("force", value);
		}
	}

	///<summary>Request options for GetTransform <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/get-transform.html</para></summary>
	public class GetDataFrameTransformRequestParameters : RequestParameters<GetDataFrameTransformRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		///<summary>
		/// Whether to ignore if a wildcard expression matches no data frame transforms. (This includes `_all` string or when no data frame transforms
		/// have been specified)
		///</summary>
		public bool? AllowNoMatch
		{
			get => Q<bool? >("allow_no_match");
			set => Q("allow_no_match", value);
		}

		///<summary>skips a number of transform configs, defaults to 0</summary>
		public int? From
		{
			get => Q<int? >("from");
			set => Q("from", value);
		}

		///<summary>specifies a max number of transforms to get, defaults to 100</summary>
		public int? Size
		{
			get => Q<int? >("size");
			set => Q("size", value);
		}
	}

	///<summary>Request options for GetTransformStats <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/get-transform-stats.html</para></summary>
	public class GetDataFrameTransformStatsRequestParameters : RequestParameters<GetDataFrameTransformStatsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		///<summary>
		/// Whether to ignore if a wildcard expression matches no data frame transforms. (This includes `_all` string or when no data frame transforms
		/// have been specified)
		///</summary>
		public bool? AllowNoMatch
		{
			get => Q<bool? >("allow_no_match");
			set => Q("allow_no_match", value);
		}

		///<summary>skips a number of transform stats, defaults to 0</summary>
		public long? From
		{
			get => Q<long? >("from");
			set => Q("from", value);
		}

		///<summary>specifies a max number of transform stats to get, defaults to 100</summary>
		public long? Size
		{
			get => Q<long? >("size");
			set => Q("size", value);
		}
	}

	///<summary>Request options for PreviewTransform <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/preview-transform.html</para></summary>
	public class PreviewDataFrameTransformRequestParameters : RequestParameters<PreviewDataFrameTransformRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
	}

	///<summary>Request options for PutTransform <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/put-transform.html</para></summary>
	public class PutDataFrameTransformRequestParameters : RequestParameters<PutDataFrameTransformRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.PUT;
		///<summary>If validations should be deferred until data frame transform starts, defaults to false.</summary>
		public bool? DeferValidation
		{
			get => Q<bool? >("defer_validation");
			set => Q("defer_validation", value);
		}
	}

	///<summary>Request options for StartTransform <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/start-transform.html</para></summary>
	public class StartDataFrameTransformRequestParameters : RequestParameters<StartDataFrameTransformRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		///<summary>Controls the time to wait for the transform to start</summary>
		public TimeSpan Timeout
		{
			get => Q<TimeSpan>("timeout");
			set => Q("timeout", value);
		}
	}

	///<summary>Request options for StopTransform <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/stop-transform.html</para></summary>
	public class StopDataFrameTransformRequestParameters : RequestParameters<StopDataFrameTransformRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		///<summary>
		/// Whether to ignore if a wildcard expression matches no data frame transforms. (This includes `_all` string or when no data frame transforms
		/// have been specified)
		///</summary>
		public bool? AllowNoMatch
		{
			get => Q<bool? >("allow_no_match");
			set => Q("allow_no_match", value);
		}

		///<summary>Controls the time to wait until the transform has stopped. Default to 30 seconds</summary>
		public TimeSpan Timeout
		{
			get => Q<TimeSpan>("timeout");
			set => Q("timeout", value);
		}

		///<summary>Whether to wait for the transform to fully stop before returning or not. Default to false</summary>
		public bool? WaitForCompletion
		{
			get => Q<bool? >("wait_for_completion");
			set => Q("wait_for_completion", value);
		}
	}

	///<summary>Request options for UpdateTransform <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/update-transform.html</para></summary>
	public class UpdateDataFrameTransformRequestParameters : RequestParameters<UpdateDataFrameTransformRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		///<summary>If validations should be deferred until data frame transform starts, defaults to false.</summary>
		public bool? DeferValidation
		{
			get => Q<bool? >("defer_validation");
			set => Q("defer_validation", value);
		}
	}
}