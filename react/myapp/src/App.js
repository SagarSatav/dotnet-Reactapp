import logo from './logo.svg';
import './App.css';

import DisplayData from './Components/DisplayData';
import InsertData from './Components/InsertData';
import UpdateData from './Components/UpdateData';
import DeleteData from './Components/DeleteData';

function App() {
  return (
   <>
   <DisplayData></DisplayData>
   <InsertData></InsertData>
   <UpdateData></UpdateData>
   <DeleteData></DeleteData>
   </>
  );
}

export default App;
