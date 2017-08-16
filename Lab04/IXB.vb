Public Class IXB
    Public Shared Property pAmount As Object

    Public Shared Function NumberToText(ByVal pAmout As Double) As String
        ' TEXT '
        Dim _numberText() As String = {"", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า", "สิบ"}

        ' DIGIT ' 
        Dim _digit() As String = {"", "สิบ", "ร้อย", "พัน", "หมื่น", "แสน", "ล้าน"}
        Dim _value As String, _aWord As String, _text As String
        Dim _numberTranslatedText As String = ""
        Dim _length, _digitPosition As Integer

        _value = pAmount.ToString
        _length = Len(_value) ' Size of Value ' 

        For i As Integer = 0 To _length - 1
            ' Loop from 0 to _SIZE(-1)
            ' Position of Digit (In number)
            ' Ex
            ' Digit 1 in Position 0 (First Digit)
            ' Digit 2 in Position 1 (Second Digit)
            ' Digit 3 in Position 2 (Third digit)
            ' If i = 7 Position will equal = 1 (Second Digit)
            ' If i = 9 Position will equal = 3 (Fourth Digit)
            _digitPosition = i - (6 * ((i - 1) \ 6))
            _aWord = Mid(_value, Len(_value) - i, 1)
            _text = ""
            Select Case _digitPosition
                Case 0
                    If _aWord = "1" And _length > 1 Then
                        _text = "เอ็ด"
                    ElseIf _aWord <> "0" Then
                        _text = _numberText(CInt(_aWord))
                    End If
                Case 1
                    If _aWord = "1" Then
                        _text = _digit(_digitPosition)
                    ElseIf _aWord = "2" Then
                        _text = "ยี่" + _digit(_digitPosition)
                    ElseIf _aWord <> "0" Then
                        _text = _numberText(CInt(_aWord)) + _digit(_digitPosition)
                    End If
                Case 2, 3, 4, 5
                    If _aWord <> "0" Then
                        _text = _numberText(CInt(_aWord)) + _digit(_digitPosition)
                    End If
                Case 6
                    If _aWord = "0" Then
                        _text = "ล้าน"
                    ElseIf _aWord = "1" And _length - 1 > i Then
                        _text = "เอ็ดล้าน"
                    Else
                        _text = _numberText(CInt(_aWord)) + _digit(_digitPosition)
                    End If
            End Select
            _numberTranslatedText = _text + _numberTranslatedText
        Next

        Return _numberTranslatedText
    End Function

    Public Shared Function ThaiBaht(ByVal pAmount As Double) As String
        If pAmount = 0 Then
            Return "ศูนย์บาทถ้วน"
        End If
        Dim _integerValue As String
        Dim _decimalValue As String
        Dim _integerTranslatedText As String
        Dim _decimalTranslatedText As String
        _integerValue = Format(pAmount, "####.00")
        _decimalValue = Mid(_integerValue, Len(_integerValue) - 1, 2)
        _integerValue = Mid(_integerValue, 1, Len(_integerValue) - 3)
        _integerTranslatedText = NumberToText(CDbl(_integerValue))
        If CDbl(_decimalValue) = 0 Then
            _decimalTranslatedText = NumberToText(CDbl(_decimalValue))
        Else
            _decimalTranslatedText = ""
        End If
        If _decimalTranslatedText.Trim = " " Then
            _integerTranslatedText += "บาทถ้วน"
        Else
            _integerTranslatedText += "บาท" & _decimalTranslatedText & "สตางค์"
        End If
        Return _integerTranslatedText
    End Function
End Class
