## Close the Current Form  
**this.Close();**  

---

## Exit the Entire Application  
**Application.Exit();**  

---
<p>
## in main form add other from  
**1st isMdiContainer = will be true** 
**2nd**
```csharp
OtherForm? P1; 
private void Page1_Click(object sender, EventArgs e)
        {

            if (P1 == null)
            {
                P1 = new Page1();
                P1.Location = new Point(370, 100);
                P1.FormClosed += P1_FormClosed;
                P1.MdiParent = this;
                P1.Show();
            }
            else
            {
                P1.Activate();
            }

        }
        private void P1_FormClosed(object? sender, FormClosedEventArgs e)
        {
            P1 = null;
        }



</p>

---

## Exit the Entire Application  
**Application.Exit();** 
