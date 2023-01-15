import { useState } from "react";
import axios from 'axios';

const InsertData = (props) => {
    const [proData, setproData] = useState({pname:"",purchasedate:""});
    
    const savedata = (event) => {
        event.preventDefault();
        axios.post('http://localhost:5165/api/product', proData);
    }

    const handleChange=(event)=>{
        const {name,value} =event.target
        setproData({...proData,[name]:value})

    }

    return (
        <>
            <br/><br/>
            <h4>Add new Product</h4>
            <form method="POST" onSubmit={savedata}>
                <input type="text" name="pname" onChange={handleChange} placeholder="UserName"/>
                <br/><br/>
                <input type="text" name="purchasedate" onChange={handleChange} placeholder="PurchaseDate"/>
                <br/><br/>
                <input type="Submit"/>
            </form>
        </>
    );

}
export default InsertData;