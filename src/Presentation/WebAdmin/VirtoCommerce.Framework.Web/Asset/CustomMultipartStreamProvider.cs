﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace VirtoCommerce.Framework.Web.Asset
{
	// We implement MultipartFormDataStreamProvider to override the filename of File which 
	// will be stored on server, or else the default name will be of the format like Body- 
	// Part_{GUID}. In the following implementation we simply get the FileName from 
	// ContentDisposition Header of the Request Body.
	public class CustomMultipartFormDataStreamProvider : MultipartFormDataStreamProvider
	{
		public CustomMultipartFormDataStreamProvider(string path) : base(path) { }

		public override string GetLocalFileName(HttpContentHeaders headers)
		{
			return headers.ContentDisposition.FileName.Replace("\"", string.Empty);
		}
	}
}
