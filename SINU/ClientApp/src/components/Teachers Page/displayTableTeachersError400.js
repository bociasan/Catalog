import React from "react";

class DisplayTableTeachers extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            list: [''],
            teacher: null,
            id: null
        }
        this.id = 202
        this.callApi = this.callApi.bind(this)
        this.callApi();
    }

    fetchData() {
        return fetch.apply(null, arguments).then(response => {
            if (!response.ok) {
                // create error object and reject if not a 2xx response code
                let err = new Error("HTTP status code: " + response.status)
                err.response = response
                err.status = response.status
                // throw err
                // console.log(err)
                // return err
                return "HTTP status code: " + response.status + " teacher not found."
            }
            return response.json()
        })
    }

    callApi() {
        this.fetchData(`https://localhost:44328/api/Teachers/${this.id}`)
            .then((data) => {
                console.log(data)
                if (typeof data != 'string'){
                    this.setState({
                        teacher: data
                    })
                    this.fetchData(`https://localhost:44328/api/Teachers/${this.state.teacher.Id}/materials`)
                        .then((data) => {
                            console.log(data)
                            if (typeof data != 'string') {
                                this.setState({
                                    list: data
                                })
                            }
                        })
                }
            })
    }




    render() {

        let tb_data = this.state.list.map((item) => {
            return (
                <tr key={[item.SubjectProfesorId]}>
                    <td>{item.SubjectName}</td>
                    <td>{item.StudyYearName}</td>
                    {/*<td><button className="btn btn-danger">Remove</button></td>*/}
                </tr>
            )
        })
        return (
            <div className="container">
                {this.state.teacher && <h2>Teacher {this.state.teacher.FirstName} {this.state.teacher.LastName} subjects: </h2>}
                {this.state.teacher && <table className="table table-striped table-hover align-middle">
                    <thead>
                    <tr>
                        <th>Subject</th>
                        <th>StudyYear</th>
                        {/*<th></th>*/}
                    </tr>
                    </thead>
                    <tbody>
                    {tb_data}
                    </tbody>
                </table>}
            </div>
        )
    }
}

export default DisplayTableTeachers;