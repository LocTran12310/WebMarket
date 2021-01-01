import React, { Component } from 'react';

export class Edit extends Component {
    static displayName = Edit.name;

    constructor(props) {
        super(props);
        this.state = { forecasts: [], loading: true };

    }

    componentDidMount() {
        this.populateWeatherData();
    }

    render() {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Button</th>
                    </tr>
                </thead>
                <tbody>
                    {this.state.forecasts.map(forecast =>
                        <tr key={forecast.cityId}>
                            <td>{forecast.cityName}</td>
                            <td>
                                <button onClick={() => this.deleteData(forecast.cityId)}>delete</button>
                                <button onClick={() => this.deleteData(forecast.cityId)}>edit</button>
                            </td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }
    async populateWeatherData() {
        const response = await fetch('https://localhost:44394/api/TblCities/');
        const data = await response.json();
        this.setState({ forecasts: data, loading: false });
    }


}