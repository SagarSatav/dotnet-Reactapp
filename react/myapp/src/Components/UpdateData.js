import { useState } from "react";
import axios from 'axios';

const UpdateData = (props) => {
    const [proData, setproData] = useState({pid:"",pname:"",purchasedate:""});


    
    const update = (event) => {
        event.preventDefault();
        axios.put(`http://localhost:5165/api/product/${proData.pid}`,proData);
    }

    const handleChange=(event)=>{
        const {name,value} =event.target
        setproData({...proData,[name]:value})

    }

    return (
        <>
            <br/><br/>
            <h4>Update Product</h4>
            <form method="PUT" onSubmit={update}>
                <input type="text" name="pid" onChange={handleChange} placeholder="pid"/>
                <br></br><br></br>
                <input type="text" name="pname" onChange={handleChange} placeholder="UserName"/>
                <br/><br/>
                <input type="text" name="purchasedate" onChange={handleChange} placeholder="PurchaseDate"/>
                <br/><br/>
                <input type="Submit"/>
            </form>
        </>
    );

}
export default UpdateData;