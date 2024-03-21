function inventoryList() {
    
    var items = [];
    function add(item) {
        if (item !== null){
          const index = items.indexOf(item);
          if (index === -1){
              items.push(item);
          }
        }   
    }
    function remove(item) {  
        const index = items.indexOf(item);
        if (index > -1) {
            items.splice(index, 1);
        }
    }
    function getList() {
        if (items){
           return items;
        } else {
           return null; 
        }
    }
    
    return {
        add: add,
        getList: getList,
        remove: remove
    };
}

function main() {
  
  const obj = inventoryList();
  const operationCount = 3;
  
  let inputData = ['add Pineapple', 'remove Apple', 'getList'];

  for(let k=1; k<= operationCount; k++)
  {
      for(let i = 0; i < inputData.length; i++) {
          const operationInfo = inputData[i].trim().split(' ');
          if (operationInfo[0] === 'add') {
              obj.add(operationInfo[1]);
          } else if (operationInfo[0] === 'remove') {
              obj.remove(operationInfo[1]);
          } else if (operationInfo[0] === 'getList') {
              const res = obj.getList();
              if (res.length === 0) {
              console.log('No Items\n');
              } else {
                  console.log(`${res.join(',')}\n`);
              }
          }
      }
  }
}