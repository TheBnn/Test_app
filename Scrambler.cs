using System;
using System.Collections.Generic;
using System.Text;

namespace PartOne
{
	public static class Scrambler
	{
		//Алфавит
		private static char[] characters = new char[] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
												'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
												'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ',
												'Э', 'Ю', 'Я', ' ', '1', '2', '3', '4', '5', '6', '7',
												'8', '9', '0' };
		//Опорная длинна алфавита
		private static int N = characters.Length;

		//зашифровать
		public static string Encode(string source, string key)
		{
			source = source.ToUpper();
			key = key.ToUpper();

			string result = "";

			int keyword_index = 0;

			foreach (char symbol in source)
			{
				int c = (Array.IndexOf(characters, symbol) +
					Array.IndexOf(characters, key[keyword_index])) % N;

				result += characters[c];

				keyword_index++;

				if ((keyword_index + 1) == key.Length)
					keyword_index = 0;
			}

			return result;
		}

		//расшифровать
		public static string Decode(string source, string key)
		{
			source = source.ToUpper();
			key = key.ToUpper();

			string result = "";

			int keyword_index = 0;

			foreach (char symbol in source)
			{
				int p = (Array.IndexOf(characters, symbol) + N -
					Array.IndexOf(characters, key[keyword_index])) % N;

				result += characters[p];

				keyword_index++;

				if ((keyword_index + 1) == key.Length)
					keyword_index = 0;
			}

			return result;
		}



		//Надеюсь так можно было ))))))
		public static IEnumerable<string> Encode(IEnumerable<string> source, string key)
		{
			IEnumerable<string> result = new string[] {};
			foreach (var item in source)
			{
				result = result.Add(Encode(item,key));
			}

			return result;
		}
		public static IEnumerable<string> Decode(IEnumerable<string> source, string key)
		{
			IEnumerable<string> result = new string[] {};
			foreach (var item in source)
			{
				result = result.Add(Decode(item, key));
			}

			return result;
		}	
		private static IEnumerable<T> Add<T>(this IEnumerable<T> e, T value)
		{
			foreach (var cur in e)
			{
				yield return cur;
			}
			yield return value;
		}

	}
}
