import React, { Component } from 'react';



export class FetchData extends Component {
  static displayName = FetchData.name;

  constructor(props) {
    super(props);
      this.state = { forecasts: [], loading: true };
     
  }

  componentDidMount() {
    this.populateWeatherData();
   }

    async deleteData(id) {
        let response = await fetch(`https://localhost:44394/api/TblCities/${id}`, {
            method: "DELETE",
        });
        this.populateWeatherData()
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
                          </td>
                      </tr>
                  )}
              </tbody>
          </table>
    );
  }
  async populateWeatherData() {
      const response = await fetch('https://localhost:44394/api/TblCities');
     const data = await response.json();
    this.setState({ forecasts: data, loading: false });
    }

    
}
