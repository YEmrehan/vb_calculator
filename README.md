# VB Calculator: A Simple Calculator Program

This project demonstrates how to build a basic calculator application using **Visual Basic (VB.NET)**. The program features a graphical user interface (GUI) for performing arithmetic operations like addition, subtraction, multiplication, and division.

---

## 🚀 Key Features

- **User-Friendly Interface:**
  - Intuitive design for entering numbers and selecting operations.

- **Core Arithmetic Operations:**
  - Supports addition, subtraction, multiplication, and division.

- **Error Handling:**
  - Handles invalid inputs and division by zero gracefully.

- **Extensible Design:**
  - Modular code structure allows for easy addition of advanced features.

---

## 🛠 Code Example

### Visual Basic Code
```vb
Public Class Calculator

    Private firstNumber As Double
    Private secondNumber As Double
    Private operation As String

    ' Handle number button clicks
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        txtDisplay.Text &= CType(sender, Button).Text
    End Sub

    ' Handle operator button clicks
    Private Sub Operator_Click(sender As Object, e As EventArgs) Handles btnAdd.Click, btnSubtract.Click, btnMultiply.Click, btnDivide.Click
        firstNumber = Double.Parse(txtDisplay.Text)
        operation = CType(sender, Button).Text
        txtDisplay.Clear()
    End Sub

    ' Perform calculation
    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        Try
            secondNumber = Double.Parse(txtDisplay.Text)
            Select Case operation
                Case "+"
                    txtDisplay.Text = (firstNumber + secondNumber).ToString()
                Case "-"
                    txtDisplay.Text = (firstNumber - secondNumber).ToString()
                Case "*"
                    txtDisplay.Text = (firstNumber * secondNumber).ToString()
                Case "/"
                    If secondNumber <> 0 Then
                        txtDisplay.Text = (firstNumber / secondNumber).ToString()
                    Else
                        txtDisplay.Text = "Error: Division by zero"
                    End If
            End Select
        Catch ex As Exception
            txtDisplay.Text = "Error: Invalid input"
        End Try
    End Sub

    ' Clear the display
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Clear()
        firstNumber = 0
        secondNumber = 0
    End Sub

End Class
```

---

## 🌍 Use Cases

- **Basic Arithmetic:**
  - Perform quick calculations directly within the application.

- **Learning Project:**
  - An excellent starting point for beginners learning VB.NET and GUI programming.

---

## 🛠 Future Enhancements

- **Advanced Mathematical Functions:**
  - Add support for square roots, exponents, and trigonometric functions.

- **Memory Features:**
  - Include buttons for memory recall (MR), memory clear (MC), and memory add (M+).

- **Keyboard Support:**
  - Allow users to enter numbers and operations using the keyboard.

- **Theme Customization:**
  - Add light and dark mode options for the interface.

---

## 🎯 Benefits

- **Simple and Interactive:** Provides a hands-on way to learn VB.NET programming.
- **Modular Design:** Code can be expanded to include more features easily.
- **Practical Utility:** A useful tool for basic calculations.

---

## 🌟 Conclusion

This VB.NET calculator program is a straightforward project that introduces core concepts of GUI development and event handling. Its simplicity makes it ideal for beginners, while its modular design ensures scalability for more advanced features.

💡 **Start building and enhancing your VB.NET calculator today!**
