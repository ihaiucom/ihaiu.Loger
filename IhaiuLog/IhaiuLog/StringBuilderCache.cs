using System.Text;

namespace ihaiu.logs
{
	public static class StringBuilderCache 
	{
		[System.ThreadStatic]
		static StringBuilder _cache = new StringBuilder();
		private const int MAX_BUILDER_SIZE = 512;    

		public static StringBuilder Acquire(int capacity = 256)
		{
			StringBuilder sb = _cache;

			if (sb != null && sb.Capacity >= capacity)
			{
				_cache = null;
				sb.Length = 0;
				//            sb.Clear();
				return sb;
			}

			return new StringBuilder(capacity);        
		}

		public static string GetStringAndRelease(StringBuilder sb)
		{
			string str = sb.ToString();
			Release(sb);
			return str;
		}

		public static void Release(StringBuilder sb)
		{
			if (sb.Capacity <= MAX_BUILDER_SIZE)
			{
				_cache = sb;            
			}
		}
	}
}