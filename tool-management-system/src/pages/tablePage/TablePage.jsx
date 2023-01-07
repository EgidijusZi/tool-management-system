import React from 'react'
import { apiService } from './../../services/business/api';
import { useState, useEffect } from 'react';
import { actions as initialActions, setActionHandlers }  from '../../components/table/Actions';
import { BasicTable } from '../../components/table/BasicTable';

const TablePage = ({columns, apiBasePath}) => {

  const tablePageApiService = apiService(apiBasePath)

  const [rows, setRows] = useState([]);

  const fetchData = async () => {
    const response = await tablePageApiService.fetchAll();
    setRows(response.data);
  };

  useEffect(() => {
    fetchData();
  }, [apiBasePath]);

  const handleDelete = async (row) => {
    await tablePageApiService.delete(row.id);
    fetchData();
  };

  const handleEdit = async () => {
    return;
  }

  const actions = setActionHandlers(initialActions, [handleEdit, handleDelete]);

  return <BasicTable columns={columns} rows={rows} actions={actions} />;
}

export default TablePage