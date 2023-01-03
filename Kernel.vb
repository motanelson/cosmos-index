Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.IO
Imports Cosmos.HAL

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



			Dim s As String() = GetLines()


			For Each ss In s
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

				End If

			Next


allkey:

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
					If labelss(aa) = name Then
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
		End Sub


		Protected Overrides Sub BeforeRun()

			Dim n As Integer
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
