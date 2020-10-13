using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SincUtilities
{
	public static class Utils
	{
		/// <summary>
		/// Random number generator
		/// </summary>
		private static System.Random rng = new System.Random();

		/// <summary>
		/// Removes 'months' months from the SDateTime 'old'
		/// </summary>
		/// <param name="old">The SDateTime object</param>
		/// <param name="months">The amount of months to subtract from the SDateTime</param>
		/// <returns>new SDateTime with old - months</returns>
		public static SDateTime RemoveDateTime(SDateTime old, int months)
		{
			return old - new SDateTime(months, 0);
		}

		/// <summary>
		/// Shuffles a list of objects
		/// </summary>
		/// <typeparam name="T">The type of the objects inside the list</typeparam>
		/// <param name="list">The list of objects</param>
		public static void ShuffleList<T>(this IList<T> list)
		{
			int n = list.Count;
			while (n > 1)
			{
				n--;
				int k = rng.Next(n + 1);
				T value = list[k];
				list[k] = list[n];
				list[n] = value;
			}
		}

		/// <summary>
		/// Makes the first letters from string 'str' to uppercase letters.
		/// </summary>
		/// <param name="str">The string to manipulate</param>
		/// <returns>String with uppercase first letters</returns>
		public static string UpperFirstLetters(string str)
		{
			string[] arr = str.Split('_');
			string result = "";

			foreach (string word in arr)
			{
				if (result == "")
					result = word.First().ToString().ToUpper() + word.Substring(1);
				else
					result += " " + word.First().ToString().ToUpper() + word.Substring(1);
			}
			return result;
		}

		/// <summary>
		/// Adds/Subtracts the percentage 'percentage' from the value 'value'
		/// </summary>
		/// <param name="value">The value (similar to 100%)</param>
		/// <param name="percentage">The percentage to subtract</param>
		/// <param name="subtract">If true will subtract, if false will add</param>
		/// <returns>New value</returns>
		public static float GetPercentage(float value, float percentage, bool subtract = true)
		{
			float perc = (percentage / 100) * value;
			if (subtract)
				value -= perc;
			else
				value += perc;
			return value;
		}

		/// <summary>
		/// Replaces values 'values' with 'replacements'
		/// </summary>
		/// <param name="str">The basestring</param>
		/// <param name="values">The values</param>
		/// <param name="replacements">The replacements</param>
		/// <returns>New string based on basestring with all values replaced</returns>
		public static string ReplaceValues(string str, string[] values, string[] replacements)
		{
			if (values.Length != replacements.Length)
				return "{VALUES != REPLACEMENTS}";

			for (int i = 0; i < values.Length; i++)
			{
				str.Replace(values[i], replacements[i]);
			}
			return str;
		}

		/// <summary>
		/// Replaces values 'values' with 'replacements'
		/// </summary>
		/// <param name="str">The basestring</param>
		/// <param name="values">The values separated by |</param>
		/// <param name="replacements">The replacements separated by |</param>
		/// <returns>New stirng based on basestring with all values replaced</returns>
		public static string ReplaceValues(string str, string values, string replacements)
		{
			return ReplaceValues(str, values.Split('|'), replacements.Split('|'));
		}

		/// <summary>
		/// Replaces values 'pairs.Keys' with replacements 'pairs.Values
		/// </summary>
		/// <param name="str">The basestring</param>
		/// <param name="pairs">Keyvaluepairs with Keys as values and Replacements as Values</param>
		/// <returns></returns>
		public static string ReplaceValues(string str, params KeyValuePair<string,string>[] pairs)
		{
			List<string> values = new List<string>();
			List<string> replacements = new List<string>();
			foreach(KeyValuePair<string,string> kvp in pairs)
			{
				values.Add(kvp.Key);
				replacements.Add(kvp.Value);
			}
			return ReplaceValues(str, values.ToArray(), replacements.ToArray());
		}
	}
}
