import React, { Component, useState } from 'react';

const Home = () => {

    const [data, setData] = useState("");
    const [result, setResult] = useState("");
    const [list, setList] = useState([]);

    const handleOnChange = (e) => {
        setData(e.target.value);
    }

    const handleOnClick = async () => {
        const response = await fetch('api/v1/home/reversedInput', {
            method: 'POST',
            body: JSON.stringify({
                "input": data
            }),
            headers: { 'Content-type': 'application/json' }
        });
        const temp = await response.text();
        setResult(temp);
    }

    const handleGetAll = async () => {
        const response = await fetch('api/v1/home/getAllInput', {
            method: 'GET',
        });
        const temp = await response.json();
        setList(temp);
    }

    return (
        <>
            <div>
                <text>Please input here: </text>
                <input type="text" onChange={handleOnChange}></input>
                <input type="button" onClick={handleOnClick} value="Submit"></input>
                <br />
                <text>Reversed input: {result}</text>
                <br />
                <br />
                <input type="button" onClick={handleGetAll} value="Show All"></input>
                {list &&
                    <table className="table">
                        <thead>
                            <tr>
                                <th>Input</th>
                                <th>Reversed Input</th>
                            </tr>
                        </thead>
                        <tbody>
                            {list.map((item, index) => {
                                return (
                                    <tr key={index}>
                                        <td>{item.input}</td>
                                        <td>{item.reversedInput}</td>
                                    </tr>
                                );
                            })}
                        </tbody>
                    </table>
                }
            </div>
        </>
    );
}

export default Home;