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

    callApi() {
        fetch(`https://localhost:44328/api/Teachers/${this.id}`).then(
            (response) => response.json()
        ).then((data) => {
            console.log(data)
            this.setState({
                teacher: data
            })
            // console.log(this.state.list[0].User.FirstName)
            // console.log(this.state.teacher)

            fetch(`https://localhost:44328/api/Teachers/${this.state.teacher.Id}/materials`).then(
                (response) => response.json()
            ).then((data) => {
                console.log(data)
                this.setState({
                    list: data
                })
                // console.log(this.state.list[0].User.FirstName)
            })
        })
    }

    // callApi() {
    //     fetch(`https://localhost:44328/api/Teachers/${this.id}`)
    //         .then(function(res){
    //             if (res.ok) {
    //                 console.log('ok')
    //                 return res.json()
    //             } else {
    //                 return res.json()
    //                     .then(function(err) {
    //                         console.log('400')
    //                         throw new Error("There's an error upstream and it says " + err.message);
    //                     })
    //             }
    //         })
    // }

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
                <table className="table table-striped table-hover align-middle">
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
                </table>
            </div>
        )
    }
}

export default DisplayTableTeachers;