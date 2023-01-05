Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.IO
Imports Cosmos.HAL
Imports Sys = Cosmos.System
Imports System.Runtime.InteropServices
Imports System.Threading


Namespace basic

	Public Class Kernel
		Inherits Cosmos.System.Kernel
		Dim sss As String
		Dim s As String
		Dim ss As String
		Dim n As Integer
		Dim c As String
		Dim ii As Integer
		Dim i As Integer
		Dim keycount As Integer
		Dim varscount As Integer
		Dim keywords(600) As String

		Dim par(3000) As Integer
		Dim labelss(3000) As String
		Dim labeladdress(3000) As Integer
		Dim labelstate(3000) As Integer
		Dim labelindex As Integer
		Dim vars(3000) As String
		Dim varvalue(3000) As String
		Dim varnumber(3000) As Double
		Dim errorss As Integer
		Dim errorssi As Integer
		Dim parcount As Integer
		Dim par1 As String

		Dim vvv As String
		Dim t1 As String
		Dim tt1 As String
		Dim t As String
		Dim tt As String
		Dim iii As Integer
		Dim aa As Integer
		Dim aaa As Integer
		Dim bb As Integer
		Dim bbb As Integer
		Dim bbb1 As Integer
		Dim bbb2 As Integer
		Dim bbb3 As Integer
		Dim bbb4 As Integer
		Dim bbb5 As Integer
		Dim bbb6 As Integer
		Dim tc As String
		Dim tc1 As String
		Dim tc2 As String
		Dim tc3 As String
		Dim tc4 As String
		Dim tc5 As String
		Dim tc6 As String
		Dim forvar(1300) As Integer
		Dim forfrom(1300) As Integer
		Dim forinto(1300) As Integer
		Dim forstep(1300) As Integer
		Dim foraddress(1300) As Integer
		Dim forcount As Integer
		Dim varstype(3000) As Integer
		Dim line11(3000) As Integer
		Dim labeldefined(3000) As Integer
		Dim txtbody As String
		Dim debug As String
		Dim rtxt() As String
		Dim ts As Integer

		Dim fi As Long
		Dim fn As Double
		Private Sub addkey(name As String, ppar As Integer)

			keywords(keycount) = name
			par(keycount) = ppar
			keycount = keycount + 1

		End Sub


		Private Sub startcode()




			'keyword list 
			'keyword list 
			keycount = 0
			addkey("print", 2)
			addkey("set", 3)
			addkey("", 1)
			addkey("echo", 2)
			addkey("wait", 2)
			addkey("integer", 3)
			addkey("let", 3)
			addkey("add", 4)
			addkey("sub", 4)
			addkey("exit", 1)
			addkey("label", 2)
			addkey("goto", 2)
			addkey("return", 1)
			addkey("like", 4)
			addkey("diferent", 4)
			addkey("big", 4)
			addkey("less", 4)
			addkey("rem", 2)
			addkey("gosub", 2)
			addkey("memfill", 4)
			addkey("memcopy", 4)
			addkey("string", 3)
			addkey("strcat", 3)
			addkey("strcopy", 3)
			addkey("memmove", 4)
			addkey("input", 3)
			addkey("memback", 4)
			addkey("memford", 4)
			addkey("strfrom", 4)
			addkey("for", 5)
			addkey("next", 1)
			addkey("pointer", 3)
			addkey("copy", 4)
			addkey("str", 3)
			addkey("val", 3)
			addkey("getnumber", 2)
			addkey("printnumber", 2)
			addkey("machine", 2)
			addkey("reset", 2)
			addkey("mul", 4)
			addkey("div", 4)
			addkey("move", 3)
			addkey("alocate", 3)
			addkey("call", 6)
			addkey("file.creat", 2)
			addkey("file.open", 3)
			addkey("file.close", 2)
			addkey("file.read", 4)
			addkey("file.write", 4)
			addkey("string.len", 3)
			addkey("timer.sleep", 2)
			addkey("timer.rnd", 2)
			addkey("stack.push", 2)
			addkey("mem.peek", 3)
			addkey("mem.poke", 3)
			addkey("bits.and", 4)
			addkey("bits.not", 3)
			addkey("mem.reserve", 3)
			addkey("far.into", 4)
			addkey("far.from", 4)
			addkey("text", 3)
			addkey("string.comp", 4)
			addkey("string.lower", 2)
			addkey("string.high", 2)
			addkey(":", 2)
			addkey("string.findchr", 4)
			addkey(";", 2)
			addkey("string.findstr", 4)
			addkey("inkey", 2)
			addkey("const", 2)
			addkey("locate", 4)
			addkey("screen", 2)
			addkey("textout", 4)
			addkey("border", 2)
			addkey("float", 3)
			addkey("back", 2)
			addkey("hline", 5)
			addkey("doevents", 1)
			addkey("box", 6)
			addkey("file.chain", 2)
			addkey("file.exec", 2)
			addkey("timer.cicle", 2)
			addkey("memory", 3)
			addkey("fillstep", 5)
			addkey("color", 2)
			addkey("vline", 5) 'key 85
			addkey("nosound", 1) 'key 86
			addkey("sound", 2) 'key 87
			addkey("beep", 1) 'key 88
			addkey("memory.set", 3) 'key 89
			addkey("bitmap.creat", 4) 'key 90
			addkey("bitmap.back", 3) 'key 91
			addkey("bitmap.attr", 4) 'key 92
			addkey("edit", 2) 'key 93

			'code head
			'add debug
			tt1 = ""
			addhead("debug")


			'add debug
			txtbody = ""
			addtxtbody("; txt body")
		End Sub


		Private Sub clearbody()

			txtbody = ""
			addtxtbody("; txt body")
			labelindex = 0
			varscount = 0
			forcount = 0
			errorss = 0
			errorssi = 0
			iii = 0
			t = t1
			tt = tt1
			debug = ""
			ts = 1
			par1 = ""


			ss = ""
			s = ""



		End Sub

		Private Function GetLines() As String()
			Console.Write("Input: ")
			Dim inputs = Console.ReadLine()
			Return inputs.ToString().Split(Chr(13) + Chr(10))
		End Function
		Public Function finds(names As String) As Integer
			Return 0
		End Function
		Public Function findvar(names As String) As Integer
			Dim aaa As Integer
			Dim aa As Integer
			aaa = -1
			If varscount > 0 Then
				For aa = 0 To varscount - 1
					If vars(aa).CompareTo(names) = 0 Then
						aaa = aa
						GoTo findvarexit
					End If
				Next
			End If
findvarexit:
			Return aaa

		End Function



		Private Sub onRuns()


			Dim llinel As Integer
			Dim s As String() = GetLines()
			Dim ss As String = ""
onruns:

			For llinel = 0 To s.Count() - 1
				ss = s(llinel)
				ss = ss.Replace(Chr(10), "")
				ss = ss.Replace("'", Chr(34))
				Dim separete As String() = ss.Split(",")

				errorss = 1
				If separete.Count() > 0 Then
					Dim par1 As String = separete(0).Trim().ToLower()
					'key no line
					If par1.CompareTo(keywords(2)) = 0 Then
						errorssi = 2
						If 1 = separete.Count() Then
							errorssi = -1
							errorss = 0
						End If
						GoTo allkey
					End If
					'key echo,text
					If par1.CompareTo(keywords(3)) = 0 Then
						errorssi = 3
						If par(3) = separete.Length Then
							Console.WriteLine(separete(1))

						Else
							iii = 1 + iii
							GoTo errorhandler

						End If
						errorssi = -1
						errorss = 0

						GoTo allkey
					End If
					'key exit
					If par1.CompareTo(keywords(9)) = 0 Then
						errorssi = 9
						If par(9) = separete.Length Then
							Power.ACPIShutdown()
						Else
							iii = 1 + iii
							GoTo errorhandler

						End If
						errorssi = -1
						errorss = 0

						GoTo allkey
					End If
					'key string ,value
					If par1.CompareTo(keywords(21)) = 0 Then
						errorssi = 21

						If par(21) = separete.Count() Then
							tc = separete(1).Trim().ToUpper()
							Dim findsvari As Integer
							findsvari = findvar(tc)
							If findsvari = -1 And tc.CompareTo("") <> 0 Then
								addvar(tc, 1, iii, separete(2), 0.00)


							Else
								iii = 1 + iii
								GoTo errorhandler
							End If
							errorssi = -1
							errorss = 0
						End If
						GoTo allkey
					End If


					'key print,var
					If par1.CompareTo(keywords(0)) = 0 Then
						errorssi = 0

						If par(0) = separete.Count() Then

							tc = separete(1).Trim().ToUpper()

							bbb = findvar(tc)


							If bbb <> -1 And tc.CompareTo("") <> 0 Then


								If varstype(bbb) = 0 Then

									Console.WriteLine(varnumber(bbb).ToString())

									errorssi = -1
									errorss = 0


								Else

									If varstype(bbb) = 1 Then


										Console.WriteLine(varvalue(bbb))
										errorssi = -1
										errorss = 0


									Else
										iii = 1 + iii
										GoTo errorhandler
									End If

								End If
							End If
						End If
						GoTo allkey
					End If

					'key integer ,var,number value
					If par1.CompareTo(keywords(5)) = 0 Then
						errorssi = 5

						If par(5) = separete.Length Then
							tc = separete(1).Trim().ToUpper()
							If findvar(tc) = -1 And tc.CompareTo("") <> 0 Then
								addvar(tc, 0, iii, "", Double.Parse(separete(2).Trim()))

							Else
								iii = 1 + iii
								GoTo errorhandler
							End If
							errorssi = -1
							errorss = 0
						End If
						GoTo allkey
					End If
					'key float ,var,number value
					If par1.CompareTo(keywords(74)) = 0 Then
						errorssi = 74

						If par(74) = separete.Length Then
							tc = separete(1).Trim().ToUpper()
							If findvar(tc) = -1 And tc.CompareTo("") <> 0 Then
								addvar(tc, 0, iii, "", Double.Parse(separete(2).Trim()))

							Else
								iii = 1 + iii
								GoTo errorhandler
							End If
							errorssi = -1
							errorss = 0
						End If
						GoTo allkey
					End If
					'key set ,var,value
					If par1.CompareTo(keywords(1)) = 0 Then
						errorssi = 1

						If par(1) = separete.Length Then
							tc = separete(1).Trim().ToUpper()
							Dim ifindvar As Integer

							ifindvar = findvar(tc)
							If ifindvar <> -1 And tc.CompareTo("") <> 0 Then
								If varstype(ifindvar) = 0 Then
									varnumber(ifindvar) = Double.Parse(separete(2).Trim())
								Else
									varvalue(ifindvar) = separete(2)
								End If

							Else
								iii = 1 + iii
								GoTo errorhandler
							End If
							errorssi = -1
							errorss = 0
						End If
						GoTo allkey
					End If
					'key let ,var,value
					If par1.CompareTo(keywords(6)) = 0 Then
						errorssi = 6

						If par(6) = separete.Length Then
							tc = separete(1).Trim().ToUpper()
							Dim ifindvar As Integer

							ifindvar = findvar(tc)
							If ifindvar <> -1 And tc.CompareTo("") <> 0 Then
								If varstype(ifindvar) = 0 Then
									varnumber(ifindvar) = Double.Parse(separete(2).Trim())
								Else
									varvalue(ifindvar) = separete(2)
								End If

							Else
								iii = 1 + iii
								GoTo errorhandler
							End If
							errorssi = -1
							errorss = 0
						End If
						GoTo allkey
					End If
					'key beep
					If par1.CompareTo(keywords(88)) = 0 Then
						errorssi = 88
						If par(88) = separete.Length Then
							Console.Beep()
						Else
							iii = 1 + iii
							GoTo errorhandler

						End If
						errorssi = -1
						errorss = 0

						GoTo allkey
					End If
					'key timer.sleep ,var
					If par1.CompareTo(keywords(50)) = 0 Then
						errorssi = 50

						If par(50) = separete.Length Then
							tc = separete(1).Trim().ToUpper()
							Dim ifindvar As Integer

							ifindvar = findvar(tc)
							If ifindvar <> -1 And tc.CompareTo("") <> 0 Then
								If varstype(ifindvar) = 0 Then
									Thread.Sleep(varnumber(ifindvar))
								Else
									GoTo errorhandler

								End If

							Else
								iii = 1 + iii
								GoTo errorhandler
							End If
							errorssi = -1
							errorss = 0
						End If
						GoTo allkey
					End If
					'key edit,filename.idx to chain control 
					If par1.CompareTo(keywords(93)) = 0 Then
						errorssi = 93

						If par(93) = separete.Length Then
							tc = separete(1).Trim()



							If tc.CompareTo("") <> 0 Then





								Console.WriteLine("enter a empty line to exit")
								Dim sss1 As String = ""
								Dim ssss1 As String = "."
								While ssss1.CompareTo("") <> 0

									Dim Input As String = Console.ReadLine()
									sss1 = sss1 + Input + Chr(13) + Chr(10)
									ssss1 = Input
								End While


								File.Create("0:\" + tc)
								File.WriteAllText("0:\" + tc, sss1)




							Else
								iii = 1 + iii
								GoTo errorhandler
							End If
							errorssi = -1
							errorss = 0
						End If
						GoTo allkey
					End If
					'key file.chain,filename .com to chain control
					If par1.CompareTo(keywords(79)) = 0 Then
						errorssi = 79

						If par(79) = separete.Length Then
							tc = separete(1).Trim()



							If tc.CompareTo("") <> 0 Then





								Console.WriteLine("loading file.....")
								Dim ssss As String = ""
								s = File.ReadAllText("0:\" + tc).Split(Chr(13))


								forcount = 0
								varscount = 0
								labelindex = 0
								errorss = 0
								errorssi = 0
								GoTo onruns
							Else
								iii = 1 + iii
								GoTo errorhandler
							End If
							errorssi = -1
							errorss = 0
						End If
						GoTo allkey

					End If
					'key :,label id
					If par1.CompareTo(keywords(64)) = 0 Then
						errorssi = 64

						If par(64) = separete.Length Then
							tc = separete(1).Trim().ToUpper()
							Dim ifindvar As Integer

							ifindvar = findlabel(tc)
							If ifindvar = -1 And tc.CompareTo("") <> 0 Then
								addlabel(tc, 1, iii, 1)


							Else
								If labeldefined(ifindvar) = 0 And tc.CompareTo("") <> 0 Then
									labeldefined(ifindvar) = 1
									labelstate(ifindvar) = 1
									labeladdress(ifindvar) = iii
								Else


									iii = 1 + iii
									GoTo errorhandler
								End If
							End If

							errorssi = -1
							errorss = 0
						End If
						GoTo allkey
					End If
					'key goto,label id
					If par1.CompareTo(keywords(11)) = 0 Then
						errorssi = 11

						If par(11) = separete.Length Then
							tc = separete(1).Trim().ToUpper()
							Dim ifindvar As Integer

							Dim nn As Integer = 0
							ifindvar = findlabel(tc)

							If ifindvar = -1 And tc.CompareTo("") <> 0 Then

								addlabel(tc, 0, iii, 0)
								Dim ttc3 As String = ":"
								Dim ttc2 As String = tc
								For nn = llinel + 1 To s.Count() - 1
									ss = s(nn)

									ss = ss.Replace(Chr(10), "")
									ss = ss.Replace("'", Chr(34))
									separete = ss.Split(",")

									par1 = separete(0).Trim().ToLower()
									If par1.CompareTo(ttc3) = 0 Or par1.CompareTo("label") = 0 Then

										tc = separete(1).Trim().ToUpper()
										Dim ifindvar2 As Integer

										ifindvar2 = findlabel(tc)
										If ifindvar2 = -1 And tc.CompareTo("") <> 0 Then

											addlabel(tc, 0, nn, 0)

										End If
										If tc.CompareTo(ttc2) = 0 Then
											iii = nn
											llinel = nn
											If llinel > s.Count() - 1 Then GoTo escapehandler
											GoTo allkey

										End If
									End If


								Next
								iii = 1 + iii
								GoTo errorhandler
							Else
								If labeldefined(ifindvar) = 0 And tc.CompareTo("") <> 0 Then
									labeldefined(ifindvar) = 1
									labelstate(ifindvar) = 1
									iii = labeladdress(ifindvar)
									llinel = iii
									If llinel > s.Count() - 1 Then GoTo escapehandler
									GoTo allkey
								Else


									iii = 1 + iii
									GoTo errorhandler
								End If
							End If

							errorssi = -1
							errorss = 0
						End If
						GoTo allkey
					End If
					'key add,var3,var1,var2
					If par1.CompareTo(keywords(7)) = 0 Then
						errorssi = 7

						If par(7) = separete.Length Then
							Dim tc1 As String = separete(2).Trim().ToUpper()
							Dim tc2 As String = separete(3).Trim().ToUpper()
							tc = separete(1).Trim().ToUpper()
							Dim ifindvar As Integer
							Dim ifindvar1 As Integer
							Dim ifindvar2 As Integer
							ifindvar = findvar(tc)
							ifindvar1 = findvar(tc1)
							ifindvar2 = findvar(tc2)
							If ifindvar <> -1 And tc.CompareTo("") <> 0 And ifindvar1 <> -1 And ifindvar2 <> -1 And tc1.CompareTo("") And tc2.CompareTo("") And varstype(ifindvar) = 0 And varstype(ifindvar1) = 0 And varstype(ifindvar2) = 0 Then

								varnumber(ifindvar) = varnumber(ifindvar1) + varnumber(ifindvar2)

							Else
								iii = 1 + iii
								GoTo errorhandler
							End If
							errorssi = -1
							errorss = 0
						End If
						GoTo allkey
					End If
					'key sub,var3,var1,var2
					If par1.CompareTo(keywords(8)) = 0 Then
						errorssi = 8

						If par(8) = separete.Length Then
							Dim tc1 As String = separete(2).Trim().ToUpper()
							Dim tc2 As String = separete(3).Trim().ToUpper()
							tc = separete(1).Trim().ToUpper()
							Dim ifindvar As Integer
							Dim ifindvar1 As Integer
							Dim ifindvar2 As Integer
							ifindvar = findvar(tc)
							ifindvar1 = findvar(tc1)
							ifindvar2 = findvar(tc2)
							If ifindvar <> -1 And tc.CompareTo("") <> 0 And ifindvar1 <> -1 And ifindvar2 <> -1 And tc1.CompareTo("") And tc2.CompareTo("") And varstype(ifindvar) = 0 And varstype(ifindvar1) = 0 And varstype(ifindvar2) = 0 Then

								varnumber(ifindvar) = varnumber(ifindvar1) - varnumber(ifindvar2)

							Else
								iii = 1 + iii
								GoTo errorhandler
							End If
							errorssi = -1
							errorss = 0
						End If
						GoTo allkey
					End If
					'key mul,var3,var1,var2
					If par1.CompareTo(keywords(39)) = 0 Then
						errorssi = 39

						If par(39) = separete.Length Then
							Dim tc1 As String = separete(2).Trim().ToUpper()
							Dim tc2 As String = separete(3).Trim().ToUpper()
							tc = separete(1).Trim().ToUpper()
							Dim ifindvar As Integer
							Dim ifindvar1 As Integer
							Dim ifindvar2 As Integer
							ifindvar = findvar(tc)
							ifindvar1 = findvar(tc1)
							ifindvar2 = findvar(tc2)
							If ifindvar <> -1 And tc.CompareTo("") <> 0 And ifindvar1 <> -1 And ifindvar2 <> -1 And tc1.CompareTo("") And tc2.CompareTo("") And varstype(ifindvar) = 0 And varstype(ifindvar1) = 0 And varstype(ifindvar2) = 0 Then

								varnumber(ifindvar) = varnumber(ifindvar1) * varnumber(ifindvar2)

							Else
								iii = 1 + iii
								GoTo errorhandler
							End If
							errorssi = -1
							errorss = 0
						End If
						GoTo allkey
					End If
					'key div,var3,var1,var2
					If par1.CompareTo(keywords(40)) = 0 Then
						errorssi = 40

						If par(40) = separete.Length Then
							Dim tc1 As String = separete(2).Trim().ToUpper()
							Dim tc2 As String = separete(3).Trim().ToUpper()
							tc = separete(1).Trim().ToUpper()
							Dim ifindvar As Integer
							Dim ifindvar1 As Integer
							Dim ifindvar2 As Integer
							ifindvar = findvar(tc)
							ifindvar1 = findvar(tc1)
							ifindvar2 = findvar(tc2)
							If ifindvar <> -1 And tc.CompareTo("") <> 0 And ifindvar1 <> -1 And ifindvar2 <> -1 And tc1.CompareTo("") And tc2.CompareTo("") And varstype(ifindvar) = 0 And varstype(ifindvar1) = 0 And varstype(ifindvar2) = 0 Then

								varnumber(ifindvar) = varnumber(ifindvar1) / varnumber(ifindvar2)

							Else
								iii = 1 + iii
								GoTo errorhandler
							End If
							errorssi = -1
							errorss = 0
						End If
						GoTo allkey
					End If
					'key like,var1,var2,goto label id
					If par1.CompareTo(keywords(13)) = 0 Then
						errorssi = 13

						If par(13) = separete.Length Then
							Dim bbbbb As Boolean
							Dim tc1 As String = separete(2).Trim().ToUpper()
							Dim tc2 As String = separete(3).Trim().ToUpper()
							tc = separete(1).Trim().ToUpper()
							Dim ifindvar As Integer
							Dim ifindvar1 As Integer
							Dim ifindvar2 As Integer
							ifindvar = findvar(tc)
							ifindvar1 = findvar(tc1)

							bbbbb = ifindvar <> -1 And tc.CompareTo("") <> 0 And ifindvar1 <> -1 And tc1.CompareTo("") And varstype(ifindvar) = 0 And varstype(ifindvar1) = 0 And varnumber(ifindvar1) = varnumber(ifindvar)
							If Not (bbbbb) Then bbbbb = ifindvar <> -1 And tc.CompareTo("") <> 0 And ifindvar1 <> -1 And tc1.CompareTo("") And varstype(ifindvar) = 1 And varstype(ifindvar1) = 1 And varvalue(ifindvar1).CompareTo(varvalue(ifindvar)) = 0
							If bbbbb Then
								tc = separete(3).Trim().ToUpper()


								Dim nn As Integer = 0
								ifindvar = findlabel(tc)

								If ifindvar = -1 And tc.CompareTo("") <> 0 Then

									addlabel(tc, 0, iii, 0)
									Dim ttc3 As String = ":"
									Dim ttc2 As String = tc
									For nn = llinel + 1 To s.Count() - 1
										ss = s(nn)

										ss = ss.Replace(Chr(10), "")
										ss = ss.Replace("'", Chr(34))
										separete = ss.Split(",")

										par1 = separete(0).Trim().ToLower()
										If par1.CompareTo(ttc3) = 0 Or par1.CompareTo("label") = 0 Then

											tc = separete(1).Trim().ToUpper()


											ifindvar2 = findlabel(tc)
											If ifindvar2 = -1 And tc.CompareTo("") <> 0 Then

												addlabel(tc, 0, nn, 0)

											End If
											If tc.CompareTo(ttc2) = 0 Then
												iii = nn
												llinel = nn
												If llinel > s.Count() - 1 Then GoTo escapehandler
												GoTo allkey

											End If
										End If


									Next
									iii = 1 + iii
									GoTo errorhandler
								Else
									If labeldefined(ifindvar) = 0 And tc.CompareTo("") <> 0 Then
										labeldefined(ifindvar) = 1
										labelstate(ifindvar) = 1
										iii = labeladdress(ifindvar)
										llinel = iii
										If llinel > s.Count() - 1 Then GoTo escapehandler
										GoTo allkey
									Else


										iii = 1 + iii
										GoTo errorhandler
									End If
								End If

								errorssi = -1
								errorss = 0
							End If
							GoTo allkey
						End If



					End If
				End If

allkey:

			Next



			GoTo escapehandler
errorhandler:
			Console.WriteLine("error on line " + istr(iii) + " keyword :" + keywords(errorssi) + debug)
escapehandler:

		End Sub
		Private Function istr(a As Integer) As String
			Return a.ToString()

		End Function
		Private Function strim(a As String) As String
			Return a.Trim()

		End Function
		Private Function sucase(a As String) As String
			Return a.ToUpper()

		End Function
		Private Function slcase(a As String) As String
			Return a.ToLower()

		End Function



		Private Function addlabel(name As String, state As Integer, address As Integer, definer As Integer) As Integer
			labelss(labelindex) = name
			labeladdress(labelindex) = address
			labelstate(labelindex) = state
			labeldefined(labelindex) = definer
			labelindex = labelindex + 1
			Return labelindex
		End Function

		Private Function findlabel(name As String) As Integer
			aaa = -1
			If labelindex > 0 Then
				For aa = 0 To labelindex - 1
					If labelss(aa).CompareTo(name) = 0 Then
						aaa = aa
						GoTo findlabelexit
					End If
				Next
			End If
findlabelexit:
			Return aaa
		End Function

		Private Function findstate() As Integer
			aaa = -1
			If labelindex > 0 Then
				For aa = 0 To labelindex - 1
					If labelstate(aa) = 0 Then
						aaa = aa
						GoTo findstateexit
					End If
				Next
			End If
findstateexit:
			Return aaa
		End Function

		Private Function addfor(addresss As Integer, forvars As Integer, forfroms As Integer, forintos As Integer, forsteps As Integer) As Integer
			forvar(forcount) = forvars
			foraddress(forcount) = addresss
			forfrom(forcount) = forfroms
			forinto(forcount) = forintos
			forstep(forcount) = forsteps
			forcount = forcount + 1
			Return forcount
		End Function


		Private Sub addhead(name As String)

			tt1 = tt1 + name + Chr(13) + Chr(10)

		End Sub
		Private Sub addtail(name As String)

			tt = tt + name + Chr(13) + Chr(10)

		End Sub

		Private Sub addbody(name As String)

			t = t + name + Chr(13) + Chr(10)

		End Sub



		Private Sub addtxtbody(name As String)

			txtbody = txtbody + name + Chr(13) + Chr(10)

		End Sub

		Private Function addvar(name As String, types As Integer, line1 As Integer, value As String, numbers As Double) As Integer
			vars(varscount) = name
			varvalue(varscount) = value
			varnumber(varscount) = numbers
			varstype(varscount) = types
			line11(varscount) = line1
			varscount = varscount + 1
			Return varscount
		End Function
		Private Sub addcode(name As String)

			t1 = t1 + name + Chr(13) + Chr(10)

		End Sub
		Sub ToHelp()
			Console.WriteLine("echo,hello world")
			Console.WriteLine("exit")
			Console.WriteLine("string,s,hello world")
			Console.WriteLine("print,s")
			Console.WriteLine("integer,number,100")
			Console.WriteLine("float,number,100")
			Console.WriteLine("set,number,100")
			Console.WriteLine("let,var,  hello world    ")
			Console.WriteLine("beep")
			Console.WriteLine("time.sleep,var1")
			Console.WriteLine("edit,filename.idx")
			Console.WriteLine("file.chain,filename.idx")
			Console.WriteLine(":,label1")
			Console.WriteLine("goto,label1")
			Console.WriteLine("add,a,b,c")

		End Sub


		Protected Overrides Sub BeforeRun()

			Dim n As Integer
			Dim fs = New Sys.FileSystem.CosmosVFS()
			Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs)
			Console.BackgroundColor = ConsoleColor.Green
			Console.Clear()
			Console.WriteLine("index 32 bits")
			For n = 0 To 100
				keywords(n) = ""
			Next
			clearbody()
			startcode()
			ToHelp()
		End Sub

		Protected Overrides Sub Run()

			onRuns()

		End Sub

	End Class

End Namespace
