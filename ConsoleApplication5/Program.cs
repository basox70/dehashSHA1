using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ConsoleApplication5
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("phrase a decoder:");
			string test = Console.ReadLine();
			string hash = Dehash(test);
			Console.WriteLine("phrase decodee:");
		    Console.WriteLine(hash);

			Console.ReadKey();
		}

		static string Dehash(string text)
		{
			string[] dico = { null," ","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z","a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z","0","1","2","3","4","5","6","7","8","9","&","é","\"","'","(","-","è","_","ç","à",")","=","°","+","²","^","$","ù","*",",",";",":","!","?",".","/","§","%","µ","¨","£","¤","~","#","{","[","|","`","\\","^","@","]","}" };
			string texte = "";
			string hash = "";

            foreach (string a in dico)
			{
				foreach (string b in dico)
				{
					foreach (string c in dico)
					{
						foreach (string d in dico)
						{
							foreach (string e in dico)
							{
								foreach (string f in dico)
								{
									foreach (string g in dico)
									{
										foreach (string h in dico)
										{
											foreach (string i in dico)
											{
												foreach (string j in dico)
												{
													foreach (string k in dico)
													{
														foreach (string l in dico)
														{
															texte = a + b + c + d + e + f + g + h + i + j + k + l;
															hash = Hash(texte);
															if (hash == text)
															{
																break;
															}
														}
														if (hash == text)
														{
															break;
														}
													}
													if (hash == text)
													{
														break;
													}
												}
												if (hash == text)
												{
													break;
												}
											}
											if (hash == text)
											{
												break;
											}
										}
										if (hash == text)
										{
											break;
										}
									}
									if (hash == text)
									{
										break;
									}
								}
								if (hash == text)
								{
									break;
								}
							}
							if (hash == text)
							{
								break;
							}
						}
						if (hash == text)
						{
							break;
						}
					}
					if (hash == text)
					{
						break;
					}
				}
				if (hash == text)
				{
					break;
				}
			}
			return texte;
		}

		static string Hash(string input)
		{
			using (SHA1Managed sha1 = new SHA1Managed())
			{
				var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
				var sb = new StringBuilder(hash.Length * 2);

				foreach (byte b in hash)
				{
					// can be "x2" if you want lowercase
					sb.Append(b.ToString("x2"));
				}

				return sb.ToString();
			}
		}

	}
}
