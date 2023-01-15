import { useEffect, useState } from "react";
import axios from 'axios';

const DisplayData = (props) => {
    const [proData, setproData] = useState([]);
    useEffect(() => {
            axios.get('http://localhost:5165/api/product')
                .then(response => { setproData(response.data) });
        }
    )

    

    var renderlist = proData.map(obj => {
        return (
            <tr>
                <td>{obj.pid}</td>
                <td>{obj.pname}</td>
                <td>{obj.purchasedate}</td>
            </tr>
        );
    });

    return (
        <>
            <br/><br/>
            <table>
                <tr>
                    <th>ProductId</th>
                    <th>ProductName</th>
                    <th>PurchaseDate</th>
                </tr>
                {renderlist}
            </table>
        </>
    );

}
export default DisplayData;