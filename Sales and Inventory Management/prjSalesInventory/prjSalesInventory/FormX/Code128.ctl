VERSION 5.00
Begin VB.UserControl Code128bar 
   ClientHeight    =   1110
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   2190
   ScaleHeight     =   74
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   146
   ToolboxBitmap   =   "Code128.ctx":0000
   Begin VB.ListBox List4 
      Height          =   450
      Left            =   2790
      TabIndex        =   1
      Top             =   270
      Visible         =   0   'False
      Width           =   720
   End
   Begin VB.PictureBox Picture1 
      Appearance      =   0  'Flat
      AutoRedraw      =   -1  'True
      BackColor       =   &H80000005&
      BorderStyle     =   0  'None
      ForeColor       =   &H80000008&
      Height          =   1110
      Left            =   15
      ScaleHeight     =   74
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   146
      TabIndex        =   0
      Top             =   0
      Width           =   2190
   End
End
Attribute VB_Name = "Code128bar"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Dim CharNumber
Dim CharData
Dim CharBarData

Private Sub UserControl_Initialize()
CharNumber = Split("0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100,101,102,103,104,105,106", ",")
CharData = Split("SP__!__" & Chr(34) & "__#__$__%__&__'__(__)__*__+__,__-__.__/__0__1__2__3__4__5__6__7__8__9__:__;__<__=__>__?__@__A__B__C__D__E__F__G__H__I__J__K__L__M__N__O__P__Q__R__S__T__U__V__W__X__Y__Z__[__\__]__^_____`__a__b__c__d__e__f__g__h__i__j__k__I__m__n__o__p__q__r__s__t__u__v__w__x__y__z__{__|__}__~__DEL__FNC 3__FNC 2__SHIFT__CODE C__FNC 4__CODE A__FNC 1__Start A__Start B__Start C__Stop__", "__")
CharBarData = Split("212222,222122,222221,121223,121322,131222,122213,122312,132212,221213,221312,231212,112232,122132,122231,113222,123122,123221,223211,221132,221231,213212,223112,312131,311222,321122,321221,312212,322112,322211,212123,212321,232121,111323,131123,131321,112313,132113,132311,211313,231113,231311,112133,112331,132131,113123,113321,133121,313121,211331,231131,213113,213311,213131,311123,311321,331121,312113,312311,332111,314111,221411,431111,111224,111422,121124,121421,141122,141221,112214,112412,122114,122411,142112,142211,241211,221114,413111,241112,134111,111242,121142,121241,114212,124112,124211,411212,421112,421211,212141,214121,412121,111143,111341,131141,114113,114311,411113,411311,113141,114131,311141,411131,211412,211214,211232,2331112", ",")
End Sub
Public Sub SetBarData(BarData As String)
    
    List4.Clear
    x = BarData
    List4.AddItem "211214" 'Add the Startcode for Start B (characterset B)
    tsum = 104 'And this is the value for that startcode
    
    'Loop through all bardata, count the sum for all character and add charbardata to a listbox (temporary holder)
    For lop = 1 To Len(x)
        barchar = Mid(x, lop, 1)
        If barchar = " " Then barchar = "SP"
        For s = 0 To UBound(CharData)
            If barchar = CharData(s) Then
                List4.AddItem CharBarData(s)
                tsum = tsum + (CLng(CharNumber(s)) * lop)
                Exit For
            End If
        Next s
    Next lop
    
    'Get the checksum
    checksum = tsum - (Int(tsum / 103) * 103)
    
    'Find the CharBarData for that checksum-value
'    For j = 0 To UBound(CharNumber)
'        If CharNumber(j) = checksum Then
            List4.AddItem CharBarData(checksum)
'        End If
'    Next j
    
    'Add the bardata for the stopcharacter
    List4.AddItem "2331112"
    
    'Count the width of the picturebox
    For p = 0 To List4.ListCount
        x = List4.List(p)
        For lop = 1 To Len(x)
            bw = bw + Val(Mid(x, lop, 1))
        Next lop
    Next p
    
    'Set the width of the picturebox and usercontrol
    Picture1.Width = bw + 30
    'UserControl.Width = (bw + 30) * UserControl.ScaleWidth
    
    'Write out the bars to the picturebox
    bs = 10
    For p = 0 To List4.ListCount
        x = List4.List(p)
        barcolor = vbBlack
        For lop = 1 To Len(x)
            bwn = Val(Mid(x, lop, 1))
            Picture1.Line (bs, 0)-(bs + bwn, Picture1.Height), barcolor, BF
            If barcolor = vbBlack Then barcolor = vbWhite Else barcolor = vbBlack
           bs = bs + bwn
        Next lop
    Next p
    
End Sub

Private Sub UserControl_Resize()
    'Resize the picturebox
    On Error Resume Next
    Picture1.Height = UserControl.Height
End Sub
Public Function SaveBar(FileName As String) As Long
            On Error GoTo SaveBar_Err
            SavePicture Picture1.Image, FileName
            SaveBar = 0
SaveBar_Exit:
            Exit Function

SaveBar_Err:
            SaveBar = Err.Number
            Resume SaveBar_Exit
End Function
