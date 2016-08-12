namespace Wbc.Services.Contract
{
	public class RequestHeader
	{
		public string Auth { get; set; }
	}

	public class ResponseHeader
	{
		public int ResultCode { get; set; }
		public string ErrorMessage { get; set; }
		public string Auth { get; set; }
	}

	public class RequestBase
	{
		public RequestHeader Header { get; set; }
	}

	public class ResponseBase
	{
		public ResponseHeader Header { get; set; }
	}

}