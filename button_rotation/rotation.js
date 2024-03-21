let buttonArray =[1,2,3,6,9,8,7,4]

function middleButtonClicked()
{
    let arrayLength = buttonArray.length;
    rotate(buttonArray,arrayLength);
       
    let btn1 = document.getElementById('btn1');
    let btn2 = document.getElementById('btn2');
    let btn3 = document.getElementById('btn3');
    let btn4 = document.getElementById('btn4');  
    //let btn5 = document.getElementById('btn5');
    let btn6 = document.getElementById('btn6');
    let btn7 = document.getElementById('btn7');
    let btn8 = document.getElementById('btn8');
   let btn9 = document.getElementById('btn9');
    
    btn1.innerText = buttonArray[0];
    btn2.innerText = buttonArray[1];
    btn3.innerText = buttonArray[2];
    btn6.innerText = buttonArray[3];
    btn9.innerText = buttonArray[4];
    btn8.innerText = buttonArray[5];
    btn7.innerText = buttonArray[6];
    btn4.innerText = buttonArray[7];   
    return false;
}

function rotate(arr, n)
{
    let x = arr[n-1];
    for(let index = n-1; index>0; index--)
        {
            arr[index] = arr[index-1];
        }
    arr[0] = x;
}