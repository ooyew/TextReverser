import React, { Component, useState } from 'react';

const Home = () => {

    const [data, setData] = useState("");
    const [result, setResult] = useState("");

    const handleOnChange = (e) => {
        setData(e.target.value);
    }

    const handleOnClick = async () => {
        const response = await fetch('api/v1/home', {
            method: 'POST',
            body: JSON.stringify({
                "input": data
            }),
            headers: { 'Content-type': 'application/json; charset=UTF-8'}
        });
        const temp = await response.text();
        setResult(temp);
    }

    return (
        <>
            <div>
                <text>Please input here: </text>
                <input type="text" onChange={handleOnChange}></input>
                <input type="button" onClick={handleOnClick} value="Submit"></input>
                <br />
                <text>Reversed input: {result}</text>
            </div>
            <div>
            </div>
        </>
    );
}

export default Home;