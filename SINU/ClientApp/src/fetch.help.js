function fetchData() {
    return fetch.apply(null, arguments).then(response => {
        if (!response.ok) {
            // create error object and reject if not a 2xx response code
            let err = new Error("HTTP status code: " + response.status)
            err.response = response
            err.status = response.status
            // throw err
            // console.log(err)
            return err
        }
        return response.json()
    })
}

function callApi() {
    this.fetchData(`https://localhost:44328/api/Teachers/${this.id}`)
        .then((data) => {
            console.log(data)
            this.setState({
                teacher: data
            })
        })
}




        // callApi() {
        //     fetch(`https://localhost:44328/api/Teachers/${this.id}`).then(
        //         (response) => response.json()
        //     ).then((data) => {
        //         console.log(data)
        //         this.setState({
        //             teacher: data
        //         })
        //         // console.log(this.state.list[0].User.FirstName)
        //         // console.log(this.state.teacher)
        //
        //         fetch(`https://localhost:44328/api/Teachers/${this.state.teacher.Id}/materials`).then(
        //             (response) => response.json()
        //         ).then((data) => {
        //             console.log(data)
        //             this.setState({
        //                 list: data
        //             })
        //             // console.log(this.state.list[0].User.FirstName)
        //         })
        //     })
        // }


        // callApi() {
        //     fetch(`https://localhost:44328/api/Teachers/${this.id}`)
        //         .then(function(res){
        //             if (res.ok) {
        //                 console.log('ok')
        //                 return res.json()
        //                 // console.log(res.json())
        //             } else {
        //                         console.log('400')
        //             }
        //         }).then((data) => {
        //                     console.log(data)
        //                     this.setState({
        //                         teacher: data
        //                     })
        //                     // console.log(this.state.list[0].User.FirstName)
        //                 })
        // }