import React, { Component } from "react";
import "./App.css";
import axios from "axios";
import { Header, Icon, List } from "semantic-ui-react";

class App extends Component {
  state = {
    values: []
  };

  componentDidMount() {
    axios.get("http://localhost:5000/api/contacts").then(response => {
      this.setState({
        values: response.data
      });
    });
    // this.setState({
    //   values: [{id:1, name: "Value 101"}, {id: 2, name: "2nd Value"}]
    // })
  }
  render() {
    return (
      <div className="App">
        <Header as="h2">
          <Icon name="users" />
          <Header.Content>Reactivities</Header.Content>
        </Header>
        <List>
        {this.state.values.map((value: any) => (
            <List.Item key={value.id}>
              {value.firstName} <b>{value.lastName}</b>
            </List.Item>
          ))}
        </List>

        {/* <ul>
          {this.state.values.map((value: any) => (
            <li key={value.id}>
              {value.firstName} <b>{value.lastName}</b>
            </li>
          ))}
        </ul> */}
      </div>
    );
  }
}
export default App;
