import { useState } from "react";
import axios from 'axios';

const DeleteData = (props) => {
    const [proData, setproData] = useState({pid:""});
    
    const removedata = (event) => {
        event.preventDefault();
        axios.delete(`http://localhost:5165/api/product/${proData.pid}`);
    }

    const handleChange=(event)=>{
        const {name,value} =event.target
        setproData({...proData,[name]:value})
    }

    return (
        <>
            <br/><br/>
            <h4>Delete Data.</h4>
            <form method="DELETE" onSubmit={removedata}>
                <input type="text" name="pid" onChange={handleChange} placeholder="pid"/>
                <input type="Submit" value="Delete"/>
            </form>
        </>
    );

}
export default DeleteData;