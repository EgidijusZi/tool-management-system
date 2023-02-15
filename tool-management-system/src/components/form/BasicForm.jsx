import { React, useState, useEffect, useContext } from 'react';
import { roleMap } from './../helpers/RoleMap';
import {
  Button,
  Dialog,
  DialogActions,
  DialogContent,
  Select,
  TextField,
  FormControl,
  MenuItem,
  InputLabel,
} from '@mui/material';

const BasicForm = ({
  columns,
  selectedRow,
  onRequest,
  open,
  onDialogClose,
}) => {
  const [formInputs, setFormInputs] = useState({});
  const [role, setRole] = useState('');

  useEffect(() => {
    let initialFormState = selectedRow
      ? columns.reduce((accumulator, column) => {
          return { ...accumulator, [column.id]: selectedRow[column.id] };
        }, {})
      : columns.reduce((accumulator, column) => {
          return { ...accumulator, [column.id]: '' };
        }, {});
    setFormInputs(initialFormState);
  }, [selectedRow]);

  const handleChange = (event, id) => {
    if (id === 'role') {
      if (['Manager', 'Storekeeper', 'Engineer'].includes(event.target.value)) {
        setRole(event.target.value);
        setFormInputs({
          ...formInputs,
          [id]: parseInt(getKeyByValue(roleMap, event.target.value)),
        });
      } else {
        setRole('');
      }
    } else {
      setFormInputs({ ...formInputs, [id]: event.target.value });
    }
  };

  const getKeyByValue = (object, value) => {
    return Object.keys(object).find(key => object[key] === value);
  }

  const handleButtonClick = (event) => {
    event.preventDefault();
    onRequest(formInputs);
  };

  return (
    <>
      <Dialog open={open} onClose={onDialogClose}>
        <DialogContent>
          {columns.map((column) => {
            if (column.id === 'role') {
              return (
                <FormControl fullWidth sx={{ mt: 2 }}>
                  <InputLabel id={column.id}>Role</InputLabel>
                  <Select
                    key={column.id}
                    label={column.label}
                    value={role}
                    onChange={(event) => handleChange(event, column.id)}
                  >
                    <MenuItem value='Manager'>Manager</MenuItem>
                    <MenuItem value='Storekeeper'>Storekeeper</MenuItem>
                    <MenuItem value='Engineer'>Engineer</MenuItem>
                  </Select>
                </FormControl>
              );
            }
            return (
              <TextField
                key={column.id}
                id={column.id}
                label={column.label}
                variant='outlined'
                sx={{
                  display: 'flex',
                  direction: 'column',
                  mt: 2,
                  width: '300px',
                }}
                value={formInputs[column.id] || ''}
                onChange={(event) => handleChange(event, column.id)}
              ></TextField>
            );
          })}
        </DialogContent>
        <DialogActions>
          <Button
            onClick={handleButtonClick}
            variant='contained'
            sx={{ mt: 0, mr: 2 }}
          >
            Submit
          </Button>
        </DialogActions>
      </Dialog>
    </>
  );
};

export default BasicForm;
