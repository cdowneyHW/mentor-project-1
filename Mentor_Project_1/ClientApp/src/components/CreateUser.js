import React, { Component } from 'react';

export const CreateUser = async ({fname, lname}) => {
    const response = await fetch('https://localhost:44386/api/user/', {
      method: "POST",
      mode: "cors",
      cache: "no-cache",
      headers: {
        "Content-Type": "application/json"
      },
      body: JSON.stringify({firstName: fname, lastName: lname})
    });
    return response.json().data;
  };